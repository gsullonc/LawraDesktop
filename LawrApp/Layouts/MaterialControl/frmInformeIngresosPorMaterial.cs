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
		DataTable _dt2 = new DataTable();

		private int _codMaterial;
		private int _codIngreso;

		private Thread _hilo;
		public frmInformeIngresosPorMaterial(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region Hilo

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._cAdquisicion.Delete(this._codIngreso, this._codMaterial))
			{
				this.pgsLoad.Visible = false;
				this.dgvListadoMaterial.Rows.RemoveAt(this.dgvListadoMaterial.CurrentRow.Index);
				MetroMessageBox.Show(this, "El Ingreso a sido Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question);

				if (this.dgvListadoMaterial.Rows.Count > 0)
				{
					this.panelListado.Enabled = true;
					this.btmImprimir.Enabled = true;
					this.btnModificar.Enabled = true;
					this.btnEliminar.Enabled = true;
				}
				else
				{
					this.txtFiltroMaterial.Enabled = false;

					this.btnDetalle.Enabled = false;
					this.btnImprimir.Enabled = false;
					this.panelListado.Enabled = true;
				}
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cAdquisicion.MsExecpcion, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this._hilo.Abort();
		}
		private void LoadDetalleIngresos()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lDetalleIngresosOfMaterial> _listIngresos  = this._cAdquisicion.ListDetalleOfIngresosForMaterial(this._codMaterial);

			if (_listIngresos.Count > 0)
			{
				this._dt.Rows.Clear();
			
				 
				foreach (lDetalleIngresosOfMaterial item in _listIngresos)
				{
					object[] d = new object[7]
					{
						item.Codigo,
						item.CodigoMaterial,
						item.Type,
						item.EntryDate,
						item.Quantity,
						(string.IsNullOrEmpty(item.DocumentNumber))?"-": item.DocumentNumber,
						item.Price
					};

					this._dt.Rows.Add(d);
				}

				this.dgvListadoDetalle.DataSource = this._dt;

				this.dgvListadoDetalle.Columns[1].Visible = false;
				this.dgvListadoDetalle.Columns[0].Visible = false;

				this.dgvListadoDetalle.Columns[2].FillWeight = 60;
				this.dgvListadoDetalle.Columns[3].FillWeight = 80;
				this.dgvListadoDetalle.Columns[4].FillWeight = 50;
				this.dgvListadoDetalle.Columns[5].FillWeight = 80;
				this.dgvListadoDetalle.Columns[6].FillWeight = 30;


				this.pgsLoad.Visible      = false;
				this.btnModificar.Enabled = true;
				this.btnEliminar.Enabled  = true;
			}
		}

		#endregion

		#region METODOS

		private void LLenarColumn()
		{
			this._dt.Columns.Add("Codigo",          typeof(string));
			this._dt.Columns.Add("Codigo Material" ,typeof(string));
			this._dt.Columns.Add("Tipo",			typeof(string));
			this._dt.Columns.Add("F.Ingreso",       typeof(string));
			this._dt.Columns.Add("Cantidad",		typeof(string));
			this._dt.Columns.Add("Nº Documento",    typeof(string));
			this._dt.Columns.Add("Costo",           typeof(string));
		}
		private void ActionForDelete()
		{
			if (this.dgvListadoMaterial.CurrentRow != null)
			{
				DialogResult result = MetroMessageBox.Show(
					this,
					"Realmente Deseas Eliminar Este Ingreso seleccionado?\nPresiona Ok para Eliminar...",
					"ADVERTENCIA",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning
			);

				if (result == DialogResult.OK)
				{
					this._hilo = new Thread(new ThreadStart(SubmitDelete));

					this.panelListado.Enabled = false;
					this.btmImprimir.Enabled  = false;
					this.btnModificar.Enabled = false;
					this.btnEliminar.Enabled  = false;
					this.pgsLoad.Visible = true;

					this._codMaterial = Convert.ToInt32(this.dgvListadoMaterial.CurrentRow.Cells[0].Value);

					this._hilo.Start();
				}
			}
			else
				return;
		}

		private void ColumnListIngresos()
		{
			this._dt2.Columns.Add("Codigo",          typeof(string));
			this._dt2.Columns.Add("Codigo_Material", typeof(string));
			this._dt2.Columns.Add("Key",		     typeof(string));
			this._dt2.Columns.Add("Descripcion",	 typeof(string));
			this._dt2.Columns.Add("Categoria",		 typeof(string));
			this._dt2.Columns.Add("Cantidad",		 typeof(string));
		}

		private void DetallarIngresos()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadDetalleIngresos));

			this._codMaterial = Convert.ToInt32(this.dgvListadoMaterial.CurrentRow.Cells[1].Value);

			object[] dataMaterial = this._data.Tables["ListaMaterial"].Select("Codigo=" + _codMaterial)[0].ItemArray;

			this.lbDescripcion.Text = Convert.ToString(dataMaterial[1]);
			this.lblCategoria.Text  = Convert.ToString(dataMaterial[2]); 

			this.panelDetalle.Enabled = true;
			this._dt.Rows.Clear();

			this.pgsLoad.Visible = true;
			this.tabcontrolMain.SelectedTab = this.tabDetalleIngresos;

			this._hilo.Start();
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

		private void LoadDataIngresos()
		{
			CheckForIllegalCrossThreadCalls = false;

			 List<lIngresos> lingreso = this._cAdquisicion.ListIngresos();

			 if (lingreso.Count > 0)
			 {
				 foreach (lIngresos item in lingreso)
				 {
					 object[] dataMaterial = this._data.Tables["ListaMaterial"].Select("Codigo=" + item.CodigoMaterial)[0].ItemArray;

					 string Descripcion = Convert.ToString(dataMaterial[1]);
					 string Categoria	= Convert.ToString(dataMaterial[2]); 

					 object[] ingresos = new object[6]
					 {
						item.Codigo,
						item.CodigoMaterial,
						item.Key,
						Descripcion,
						Categoria,
						item.Quantity
					 };

					 this._dt2.Rows.Add(ingresos);
				 }

				 this.dgvListadoMaterial.DataSource = _dt2;

				 this.dgvListadoMaterial.Columns[0].Visible = false;
				 this.dgvListadoMaterial.Columns[1].Visible = false;
				 this.dgvListadoMaterial.Columns[2].Visible = false;

				 this.dgvListadoMaterial.Columns[3].FillWeight = 150;
				 this.dgvListadoMaterial.Columns[4].FillWeight = 50;
				 this.dgvListadoMaterial.Columns[5].FillWeight = 30;
			
				 this.panelListado.Enabled       = true;
				 this.btnDetalle.Enabled         = true;

				 this.dgvListadoMaterial.ClearSelection();

				 this.pgsLoad.Visible			= false;
			 }
			 else
			 {
				 this.txtFiltroMaterial.Enabled = false;

				 this.btnModificar.Enabled      = false;
				 this.btnEliminar.Enabled		= false;
				 this.btnImprimir.Enabled		= false;

				 MetroMessageBox.Show(this, "No se ha encontrado Informacion ", "lISTA INGRESOS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			 }
				 
		}

		private void frmInformeIngresosPorMaterial_Load(object sender, EventArgs e)
		{
			this.tabcontrolMain.SelectedTab = this.tabpagListadoIngreso;
			this.panelDetalle.Enabled = false;

			this.LLenarColumn();
			this.ColumnListIngresos();

			this._hilo = new Thread(new ThreadStart(this.LoadDataIngresos));

			this.panelListado.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void dgvListadoMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.DetallarIngresos();
		}

		private void txtFiltro_TextChanged_1(object sender, EventArgs e)
		 {
			TextBox txt = (TextBox)sender;

			this._dt2.DefaultView.RowFilter = ("Descripcion like '%" + this.txtFiltroMaterial.Text + "%'");
			this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.panelDetalle.Enabled = false;
			this.tabcontrolMain.SelectedTab = this.tabpagListadoIngreso;
			this._dt.Rows.Clear();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.dgvListadoMaterial.Rows.Count > 0)
			{
				if (this.dgvListadoMaterial.CurrentRow.Selected)
				{
					this._codIngreso = Convert.ToInt32(this.dgvListadoMaterial.CurrentRow.Cells[0].Value);
					this._codMaterial = Convert.ToInt32(this.dgvListadoMaterial.CurrentRow.Cells[1].Value);

					frmDetalleIngresos detalle = new frmDetalleIngresos(this._codIngreso, this._codMaterial, this._dt2);
					detalle.ShowDialog();
				}
				else
					return;
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.dgvListadoMaterial.Rows.Count > 0)
				this.ActionForDelete();
		}

		private void btnDetalle_Click(object sender, EventArgs e)
		{

			this.DetallarIngresos();
		}

		private void frmInformeIngresosPorMaterial_FormClosing(object sender, FormClosingEventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
		}

	}
}
