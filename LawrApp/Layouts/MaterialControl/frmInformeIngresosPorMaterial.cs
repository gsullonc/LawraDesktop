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
					this.panelListado.Enabled = true;
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

			List<lIngresos> _listIngresos  = this._cAdquisicion.ListDetalleOfIngresosForMaterial(this._codMaterial);

			if (_listIngresos.Count > 0)
			{
				this._dt.Rows.Clear();
			
				foreach (lIngresos item in _listIngresos)
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

				this.dgvListadoDetalle.Columns[1].FillWeight = 80;
				this.dgvListadoDetalle.Columns[2].FillWeight = 80;
				this.dgvListadoDetalle.Columns[3].FillWeight = 95;
				this.dgvListadoDetalle.Columns[4].FillWeight = 55;
				this.dgvListadoDetalle.Columns[5].FillWeight = 50;

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
			this._dt.Columns.Add("Fecha_Ingreso",   typeof(string));
			this._dt.Columns.Add("Cantidad",		typeof(string));
			this._dt.Columns.Add("Numero Documento",typeof(string));
			this._dt.Columns.Add("Costo",           typeof(string));
		}
		private void ActionForDelete()
		{
			if (this.dgvListadoMaterial.CurrentRow.Selected)
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
			this._dt2.Columns.Add("Tipo Ingreso",	 typeof(string));
			this._dt2.Columns.Add("Fecha_Ingreso",   typeof(string));
			this._dt2.Columns.Add("Cantidad",		 typeof(string));
			this._dt2.Columns.Add("Nº.Numero",		 typeof(string));
			this._dt2.Columns.Add("Costo",			 typeof(string));
		}

		private void DetallarIngresos()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadDetalleIngresos));

			this._codMaterial = Convert.ToInt32(this.dgvListadoMaterial.CurrentRow.Cells[1].Value);
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

					 string Key			= Convert.ToString(dataMaterial[1]);
					 string Descripcion = Convert.ToString(dataMaterial[2]);
					 string Categoria	= Convert.ToString(dataMaterial[3]); 

					 object[] ingresos = new object[10]
					 {
						item.Codigo,
						item.CodigoMaterial,
						Key,
						Descripcion,
						Categoria,
						item.Type,
						item.EntryDate,
						item.Quantity,
						item.DocumentNumber,
						item.Price
					 };

					 this._dt2.Rows.Add(ingresos);
				 }

				 this.dgvListadoMaterial.DataSource = _dt2;

				 this.dgvListadoMaterial.Columns[0].Visible = false;
				 this.dgvListadoMaterial.Columns[1].Visible = false;
				 this.dgvListadoMaterial.Columns[2].Visible = false;

				 this.dgvListadoMaterial.Columns[0].FillWeight = 50;
				 this.dgvListadoMaterial.Columns[2].FillWeight = 60;
				 this.dgvListadoMaterial.Columns[3].FillWeight = 130;
				 this.dgvListadoMaterial.Columns[4].FillWeight = 60;
				 this.dgvListadoMaterial.Columns[5].FillWeight = 50;
				 this.dgvListadoMaterial.Columns[6].FillWeight = 75;
				 this.dgvListadoMaterial.Columns[7].FillWeight = 55;
				 this.dgvListadoMaterial.Columns[8].FillWeight = 70;
				 this.dgvListadoMaterial.Columns[9].FillWeight = 45;

				 this.txtFiltroFecha.Enabled    = true;
				 this.txtFiltroIngreso.Enabled  = true;
				 this.txtFiltroMaterial.Enabled = true;

				 this.panelListado.Enabled      = true;
				 this.btnDetalle.Enabled         = true;
				 this.pgsLoad.Visible			= false;
			 }
			 else
				 MetroMessageBox.Show(this,"No se ha encontrado Informacion ","lISTA INGRESOS ",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

		private void txtFiltrarIngreso_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;

			this._dt.DefaultView.RowFilter = ("Codigo Like '%" + this.txtFiltrarIngreso.Text + "%'");
			this.dgvListadoDetalle.DataSource = this._dt.DefaultView;
		}

		private void txtFiltro_TextChanged_1(object sender, EventArgs e)
		 {
			if(string.IsNullOrEmpty(this.txtFiltroFecha.Text) && (string.IsNullOrEmpty(this.txtFiltroIngreso.Text)))
			{
				TextBox txt = (TextBox)sender;

				this._dt2.DefaultView.RowFilter = ("Descripcion like '%" + this.txtFiltroMaterial.Text + "%'");
				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;

				this.txtFiltroFecha.Enabled   = false;
				this.txtFiltroIngreso.Enabled = false;

				if(string.IsNullOrEmpty(this.txtFiltroMaterial.Text))
				{
					this.txtFiltroFecha.Enabled   = true;
					this.txtFiltroIngreso.Enabled = true;
				}
			}
			if(!string.IsNullOrEmpty(this.txtFiltroFecha.Text) && (string.IsNullOrEmpty(this.txtFiltroIngreso.Text)))
			{
				this._dt2.DefaultView.RowFilter = ("Fecha_Ingreso Like '%" + this.txtFiltroFecha.Text +
													"%' AND Descripcion like '%" + this.txtFiltroMaterial.Text + "%'");
				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
			}
			if(!string.IsNullOrEmpty(this.txtFiltroFecha.Text) && (!string.IsNullOrEmpty(this.txtFiltroIngreso.Text)))
			{
				this._dt2.DefaultView.RowFilter = ("Fecha_Ingreso Like '%" + this.txtFiltroFecha.Text
													+ "%' AND Codigo='" + this.txtFiltroIngreso.Text +
													"' AND Descripcion like '%" + this.txtFiltroMaterial.Text + "%'");

				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}

		private void txtFiltroFecha_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (string.IsNullOrEmpty(this.txtFiltroIngreso.Text))
			{
				this._dt2.DefaultView.RowFilter = ("Fecha_Ingreso Like '%" + this.txtFiltroFecha.Text + "%'");
				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
			}
			if(!string.IsNullOrEmpty(txtFiltroIngreso.Text) && string.IsNullOrEmpty(this.txtFiltroMaterial.Text))
			{
				this._dt2.DefaultView.RowFilter = ("Codigo='" + this.txtFiltroIngreso.Text + "' AND Fecha_Ingreso like'%" + this.txtFiltroFecha.Text + "%'");
				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
			}
		}

		private void txtFiltroIngreso_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if ((!string.IsNullOrEmpty(this.txtFiltroFecha.Text)) && (!string.IsNullOrEmpty(this.txtFiltroIngreso.Text)))
			{
				this._dt2.DefaultView.RowFilter = ("Fecha_Ingreso like '%" + this.txtFiltroFecha.Text + "%' AND Codigo='" + this.txtFiltroIngreso.Text + "'");
				this.dgvListadoMaterial .DataSource = this._dt2.DefaultView;
			}

			if( !string.IsNullOrEmpty(this.txtFiltroFecha.Text) && string.IsNullOrEmpty(this.txtFiltroIngreso.Text))
			{
				this._dt2.DefaultView.RowFilter = ("Fecha_Ingreso Like '%" + this.txtFiltroFecha.Text + "%'");
				this.dgvListadoMaterial.DataSource = this._dt2.DefaultView;
			}
			if( string.IsNullOrEmpty(this.txtFiltroFecha.Text))
			{
				this._dt2.DefaultView.RowFilter = ("Codigo Like '%" + this.txtFiltroIngreso.Text + "%'");
				this.dgvListadoDetalle.DataSource = this._dt2.DefaultView;
			}
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

	}
}
