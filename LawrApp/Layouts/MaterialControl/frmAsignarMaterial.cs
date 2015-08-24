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
using Objects.Tables;
using Objects.Processes;

using MetroFramework;


namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmAsignarMaterial : MetroForm
	{
		DataGeneral    _data;
		DataTable _dt = new DataTable();

		Materiales _cMaterial = new Materiales();

		AsignarMaterial _cAsignarMaterial = new AsignarMaterial();
		tMaterial _objMaterialofAula = new tMaterial();	
	
		private Thread _hilo;

		private int _cantidadIngresadoMaterial;
		private int _codSalon;
		private int _codMaterial;
		private string _key;
		private bool _gotoModify = false;
		public frmAsignarMaterial(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region HILOS

		private void LoadMaterialOfAula()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lMaterialOfAula> lista = this._cMaterial.ListforAula(this._codSalon);

			if (lista != null && lista.Any())
			{
				this.dgvListado.Enabled = true;

				foreach (lMaterialOfAula item in lista)
				{
					object[] obj = new object[6] 
					{   
						this.cboSalones.SelectedValue,
						item.Codigo,
						item.Key,
						item.Description + " " + "_" + item.Marca + " " + "_" + item.Model,
						item.Category,
						false
					};

					this._dt.Rows.Add(obj);
				}
			
				this.dgvListado.DataSource = this._dt;

				this.dgvListado.Columns["Codigo_Material"].Visible = false;
				this.dgvListado.Columns["Codigo_Aula"].Visible = false;

				this.dgvListado.Columns["Key"].FillWeight         = 60;
				this.dgvListado.Columns["Descripcion"].FillWeight = 120;
				this.dgvListado.Columns["Categoria"].FillWeight   = 45;
				this.dgvListado.Columns["Selecciona"].FillWeight  = 30;

				this.dgvListado.Columns[2].ReadOnly = true;
				this.dgvListado.Columns[3].ReadOnly = true;
				this.dgvListado.Columns[4].ReadOnly = true;
				this.dgvListado.Columns[5].ReadOnly = false;

				this.btnEliminar.Enabled = true;
				this.txtfiltro.Enabled   = true;
				this.pgsLoad.Visible     = false;
				this.dgvListado.Enabled = true;
				
				this.dgvListado.ClearSelection();
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, "No hay Materiales Registrados", "Info!", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}

			this.pgsLoad.Enabled = false;
			this.panelMain.Enabled = true;

			this._hilo.Abort();
		}


		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			int codigo = this._cMaterial.Insert();

			if (codigo > 0)
			{
				List<lkeys> keys = this._cMaterial.ListarKeys(this._codSalon, this._codSalon, this._cantidadIngresadoMaterial);

				foreach (lkeys row in keys)
				{
					object[] d = new object[6]
					{
						this._codSalon,
						this._codMaterial,
						row.Keys,
						this.txtDescripcion.Text,
						this.txtCategoria.Text,
						false
					};
					this._dt.Rows.Add(d);
				}

				this.dgvListado.DataSource = this._dt;

				this.dgvListado.Columns["Codigo_Material"].Visible = false;
				this.dgvListado.Columns["Codigo_Aula"].Visible     = false;

				this.dgvListado.Columns["Key"].FillWeight         = 60;
				this.dgvListado.Columns["Descripcion"].FillWeight = 120;
				this.dgvListado.Columns["Categoria"].FillWeight   = 45;
				this.dgvListado.Columns["Selecciona"].FillWeight  = 30;

				this.dgvListado.Columns[2].ReadOnly = true;
				this.dgvListado.Columns[3].ReadOnly = true;
				this.dgvListado.Columns[4].ReadOnly = true;
				this.dgvListado.Columns[4].ReadOnly = false;

				if (this.dgvListado.Rows.Count > 0)
					this.txtfiltro.Enabled = true;
				else
					this.txtfiltro.Enabled = false;
				this.pgsLoad.Visible = false;
				this.panelMain.Enabled = true;

				this.dgvListado.ClearSelection();
			}
			else
				MessageBox.Show("Error al generar keys de los materiale");
	
			this._hilo.Abort();
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			DataGridViewRow row = new DataGridViewRow();

			for (int i = 0; i < this.dgvListado.Rows.Count; i++)
			{
				row = this.dgvListado.Rows[i];

				if (Convert.ToBoolean(row.Cells[5].Value) == true)
				{

					this._codSalon = Convert.ToInt32(row.Cells[0].Value);
					this._codMaterial = Convert.ToInt32(row.Cells[1].Value);
					this._key = Convert.ToString(row.Cells[2].Value);

					if (this._cAsignarMaterial.Delete(Convert.ToString(row.Cells[0].Value)))
					{

						DataRow[] datos = this._dt.Select("Codigo_Aula=" + this._codSalon + 
														  "AND Codigo_Material='" + this._codMaterial + "'" +
														  "AND Key='" + this._key + "'"); ;

						this.dgvListado.Rows.RemoveAt(this._dt.Rows.IndexOf(datos[0]));

						i--;

						this.btnEliminar.Enabled = false;
						this.btnbuscar.Enabled = true;
						this.btnEliminar.Enabled = true;

						this.ResetControls();
					}
					else
					{
						this.pgsLoad.Visible = false;
						MetroMessageBox.Show(this, this._cAsignarMaterial.MsgExeption, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}

			this.pgsLoad.Visible = false;
			this.panelMain.Enabled = true;

			if (this.dgvListado.Rows.Count == 0)
			{
				
				this.dgvListado.Enabled     = false;
				this.txtDescripcion.Enabled = false;
				this.txtfiltro.Enabled      = false;
				this.btnEliminar.Enabled    = false;
			}
			else
				this.btnEliminar.Enabled = false;

			this._hilo.Abort();
		}

		private void DataAulas()
		{
			CheckForIllegalCrossThreadCalls = false;

			this.cboSalones.ValueMember = "Codigo";
			this.cboSalones.DisplayMember = "Description";
			this.cboSalones.DataSource = this._data.Tables["ListaSalones"];
			
			this.cboSalones.SelectedIndex = -1;
			this.cboSalones.Text = "Seleccione...";

			this.pgsLoad.Visible = false;
			this.cboSalones.Enabled = true;

			this._hilo.Abort();
		}

		private void FindMaterialofAula()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._objMaterialofAula = this._cAsignarMaterial.Find(this._codMaterial, Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value));

			if (this._objMaterialofAula != null)
			{
				this.cboSalones.SelectedValue  = this.dgvListado.CurrentRow.Cells[0].Value.ToString();
				this.txtDescripcion.Text       = this.dgvListado.CurrentRow.Cells[3].Value.ToString(); 
				this.txtCategoria.Text         = this._objMaterialofAula.Category.Name;
				this.txtMarca.Text			   = this._objMaterialofAula.Marca.Name;
				this.txtModelo.Text            = this._objMaterialofAula.Model;

				this.btnbuscar.Enabled		 = true; 
				this.pgsLoad.Visible		 = false;
				this.cboSalones.Enabled		 = false;
				this.btnAgregar.Enabled		 = true;

				this.panelMain.Enabled = true;
				this.txtDescripcion.Focus();
				this.nudCantidad.Enabled = true;				
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cAsignarMaterial.MsgExeption, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this._hilo.Abort();
		}

		#endregion


		#region METODOS

		void ActionForDelete()
		{
			if (this.dgvListado.CurrentRow.Selected)
			{
				this._hilo = new Thread(new ThreadStart(SubmitDelete));

				this.btnbuscar.Enabled = false;
				this.pgsLoad.Visible = true;

				this._hilo.Start();
			}
			else
				return;
		}

		private void ObtenerDataOfMaterial(int Codigo, string Descripcion, string Categoria, string Marca, string Modelo, int Cantidad)
		{
			this._codMaterial		 = Convert.ToInt32(Codigo);
			this.txtDescripcion.Text = Descripcion;
			this.txtMarca.Text       = Marca;
			this.txtCategoria.Text   = Categoria;
			this.txtModelo.Text      = Modelo;

			if(Cantidad == 0)
			{
				this.nudCantidad.Enabled = false;
				this.btnAgregar.Enabled = false;
			}
			else
			{
				this.nudCantidad.Enabled = true;
				this.btnAgregar.Enabled = true;
			}

			this._cantidadIngresadoMaterial   = Cantidad;

			this.nudCantidad.Minimum = 1;
			this.nudCantidad.Maximum = Cantidad;

			this.nudCantidad.Enabled = true;
			this.btnAgregar.Enabled  = true;
		}

		private void ResetControls()
		{
			this.panelMain.Enabled = true;

			this.txtDescripcion.Clear();
			this.txtMarca.Clear();
			this.txtModelo.Clear();
			this.txtCategoria.Clear();

			this.nudCantidad.Value   = 1;
			this.nudCantidad.Enabled = false;
			this.btnbuscar.Enabled   = true;
			this.btnAgregar.Enabled  = false;
		}

		private void JoinData()
		{
			this._cAsignarMaterial.Data.CodigoMaterial = this._codMaterial;
			this._cAsignarMaterial.Data.CodigoSalon	   = Convert.ToInt32(this.cboSalones.SelectedValue);
			this._cAsignarMaterial.Data.Quantity       = Convert.ToInt32(this.nudCantidad.Value);
		}

		private void ActionForModification()
		{
			this._hilo = new Thread(new ThreadStart(this.FindMaterialofAula));
			this._gotoModify = true;

			this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);

			this.panelMain.Enabled = false;
			this.btnbuscar.Enabled = false;
			this.pgsLoad.Visible   = true;

			this._hilo.Start();
		}
		private void AgregarColumnDatatable()
		{
			_dt.Columns.Add("Codigo_Aula",     typeof(string));
			_dt.Columns.Add("Codigo_Material", typeof(string));
			_dt.Columns.Add("Key",             typeof(string));
			_dt.Columns.Add("Descripcion",     typeof(string));
			_dt.Columns.Add("Categoria",       typeof(string));
			_dt.Columns.Add("Selecciona",      typeof(bool));
		}

		#endregion

		private void frmAsigMaterial_Load(object sender, EventArgs e)
		{
			this.AgregarColumnDatatable();

			this._hilo = new Thread(new ThreadStart(this.DataAulas));

			this.cboSalones.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();

			this.dgvListado.ClearSelection();
		}

		private void cboSalones_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.txtDescripcion.Enabled = true;
			this.btnbuscar.Enabled = true;

			if (this.dgvListado.Rows.Count > 0)
			{
				this._dt.Rows.Clear();
				this.btnEliminar.Enabled = false;
			}

			this.ResetControls();

			if (this.dgvListado.Rows.Count > 0)
			{
				this._dt.DefaultView.RowFilter = String.Empty;
				this._dt.Rows.Clear();
			}

			this._hilo = new Thread(new ThreadStart(this.LoadMaterialOfAula));
			this._codSalon = Convert.ToInt32(this.cboSalones.SelectedValue);

			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			mdlSearch search = new mdlSearch(this._data);
			search.SendMaterial += new mdlSearch.getMaterial(this.ObtenerDataOfMaterial);
			search.ShowDialog();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.SubmitInsertOrUpdate));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAsigMaterial_FormClosing(object sender, FormClosingEventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			List<DataGridViewRow> CantidadRowsChekeadas = (from item in this.dgvListado.Rows.Cast<DataGridViewRow>()
														   let valor = Convert.ToBoolean(item.Cells["Selecciona"].Value)
														   where valor
														   select item).ToList();
			if (CantidadRowsChekeadas.Count() < 0)
				return;
			this.ActionForDelete();
			
		}

		private void cboSalones_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgvListado.CurrentRow.Selected)
			{
				this.btnbuscar.Enabled = false;
				this.ActionForModification();
			}
			else
				return;
		}

		private void txtfiltro_TextChanged(object sender, EventArgs e)
		{
			this._dt.DefaultView.RowFilter = ("Descripcion like '%" + this.txtfiltro.Text + "%'");
			this.dgvListado.DataSource = this._dt.DefaultView;
		}

		private void dgvListado_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				if (this.dgvListado.CurrentRow != null)
				{
					if (this.dgvListado.Rows.Count > 0)
						this.ActionForDelete();
				}
				else
					return;
			}
		}

		private void dgvListado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;

			if (this.dgvListado.Columns[5].Name == "Selecciona")
			{
				DataGridViewRow row = new DataGridViewRow();
				for (int i = 0; i < this.dgvListado.Rows.Count; i++)
				{
					row = this.dgvListado.Rows[i];

					if (row.Cells[e.ColumnIndex].Value == null)
						Convert.ToBoolean(row.Cells[e.ColumnIndex].Value = false);

					if (((bool)row.Cells[e.ColumnIndex].Value == true))
					{
						row.Cells["key"].Style.BackColor         = Color.FromArgb(232, 232, 232);
						row.Cells["Descripcion"].Style.BackColor = Color.FromArgb(232, 232, 232);
						row.Cells["Categoria"].Style.BackColor   = Color.FromArgb(232, 232, 232);
						row.Cells["Selecciona"].Style.BackColor  = Color.FromArgb(232, 232, 232);

					}
					if ((bool)row.Cells[5].Value == false)
					{
						row.Cells["key"].Style.BackColor         = Color.White;
						row.Cells["Descripcion"].Style.BackColor = Color.White;
						row.Cells["Categoria"].Style.BackColor   = Color.White;
						row.Cells["Selecciona"].Style.BackColor  = Color.White;

						row.Cells["key"].Style.ForeColor = Color.FromArgb(90, 92, 93);
						row.Cells["Descripcion"].Style.ForeColor = Color.FromArgb(90, 92, 93);
						row.Cells["Categoria"].Style.ForeColor   = Color.FromArgb(90, 92, 93);
						row.Cells["Selecciona"].Style.ForeColor  = Color.FromArgb(90, 92, 93);
					}
				}
			}
			
		}

		private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgvListado.IsCurrentCellDirty)
			{
				this.dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}
		
	}
}
