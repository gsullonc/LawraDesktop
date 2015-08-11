using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using MaterialControl.ControlMaterial;
using Objects.Processes;
using MetroFramework;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmInformeIngresosPorMaterial : MetroForm
	{
		DataGeneral _data = new DataGeneral();
		Adquisicion _cAdquisicion = new Adquisicion();
		DataTable _dt = new DataTable();

		private int _codMaterial;
		private int _codIngreso;

		private Thread _hilo;
		public frmInformeIngresosPorMaterial(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region Hilo
			
		private void LoadDetalleIngresos()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lIngresos> _listIngresos  = this._cAdquisicion.ListDetalleOfIngresosForMaterial(this._codMaterial);
			if (_listIngresos.Count > 0)
			{				
				foreach (lIngresos item in _listIngresos)
				{
					object[] d = new object[6]
					{
						item.Codigo,
						item.Type,
						item.InsertDate,
						(string.IsNullOrEmpty(item.DocumentNumber))?"-": item.DocumentNumber,
						item.Quantity,
						item.Price
					};

					this._dt.Rows.Add(d);

				}

				this.dgvListadoDetalle.DataSource = this._dt;

				this.dgvListadoDetalle.Columns[0].Visible = false;
				this.dgvListadoDetalle.Columns[1].FillWeight = 80;
				this.dgvListadoDetalle.Columns[2].FillWeight = 80;
				this.dgvListadoDetalle.Columns[3].FillWeight = 95;
				this.dgvListadoDetalle.Columns[4].FillWeight = 55;
				this.dgvListadoDetalle.Columns[5].FillWeight = 50;

				this.pgsLoad.Visible = false;
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled = true;
			}
			
		}

		#endregion

		

		#region METODOS

		private void LLenarColumn()
		{
			this._dt.Columns.Add("Codigo", typeof(string));
			this._dt.Columns.Add("Tipo Ingreso",typeof(string));
			this._dt.Columns.Add("Fecha Ingreso", typeof(string));
			this._dt.Columns.Add("Numero Documento",typeof(string));
			this._dt.Columns.Add("Cantidad",typeof(string));
			this._dt.Columns.Add("Costo",typeof(string));
		}

		#endregion

		private void cboMaterial_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}

		private void frmInformeIngresosPorMaterial_Load(object sender, EventArgs e)
		{
			this.tabcontrolMain.SelectedTab = this.tabpagListadoIngreso;
			this.panelDetalle.Enabled = false;

			this.LLenarColumn();
			this.dgvListadoMaterial.DataSource = this._data.Tables["ListaMaterial"];

			this.dgvListadoMaterial.Columns[2].FillWeight = 45;

			this.dgvListadoMaterial.Columns[0].Visible = false;
			this.dgvListadoMaterial.Columns[3].Visible = false;
			this.dgvListadoMaterial.Columns[4].Visible = false;

			if (this.dgvListadoMaterial.Rows.Count > 0)
			{
				this.dgvListadoMaterial.Enabled = true;
				this.txtFiltro.Enabled = true;
				this.btnListar.Enabled = true;
			}
			else
				MetroMessageBox.Show(this, "No se ha encontrado Informacion de los materiales","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void dgvListadoMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.LoadDetalleIngresos));
			
			this._codMaterial = Convert.ToInt32( this.dgvListadoMaterial.CurrentRow.Cells[0].Value);
			this.panelDetalle.Enabled = true;
			this._dt.Rows.Clear();

			this.pgsLoad.Visible= true;
			this.tabcontrolMain.SelectedTab = this.tabDetalleIngresos;

			this._hilo.Start();
		}

		private void txtFiltrarIngreso_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			 this._dt.DefaultView.RowFilter = ("Codigo Like '%" + this.txtFiltrarIngreso.Text + "%'");
			this.dgvListadoDetalle.DataSource = this._dt.DefaultView;
		}

		private void txtFiltro_TextChanged_1(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = ("Description + ' ' + Category Like '%" + this.txtFiltro.Text + "%'");
			this.dgvListadoMaterial.DataSource = this._data.Tables["ListaMaterial"].DefaultView;
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}

		private void dgvListadoDetalle_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				if(this.dgvListadoDetalle.Rows.Count > 0)
				{
					if(this.dgvListadoDetalle.CurrentRow.Selected)
					{
						frmDetalleIngresos detalle = new frmDetalleIngresos(this._codIngreso,this._codMaterial,this._dt);
						detalle.ShowDialog();
					}
					else
						return;
				}
			}
		}

	}
}
