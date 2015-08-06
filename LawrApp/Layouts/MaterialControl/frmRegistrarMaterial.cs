using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

using Objects.Processes;
using System.Threading;
using Objects.Tables;
using Options;
using MaterialControl.ControlMaterial;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmRegistrarMaterial : MetroForm
	{
		private Thread		 _hilo;
		private DataGeneral  _data;
		private Materiales   _cMaterial   = new Materiales();
		private tMaterial   _objMaterial = new tMaterial();
		private int _codMaterial;
		private int _codCategoria;
		private int _codMarca;

		private bool _isNewMarca     = false;
		private bool _isNewCategoria = false;

		private bool _gotoModify;

		public frmRegistrarMaterial(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region HILOS

		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (!this._gotoModify)
			{
				int codigo = this._cMaterial.Insert();

				if (codigo > 0)
				{
					this.pgsLoad.Visible = false;
					this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];
					this.tabpageMain.SelectedTab = this.tabpagMaterial;
					MetroMessageBox.Show(this, "El Material a sido registrado correctamente", "Correcto", 
				    MessageBoxButtons.OK, MessageBoxIcon.Question);

					this.ResetControls();
					this.tabpageMain.SelectedTab = this.tabpagMaterial;
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar registrar Material", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.tabpageMain.SelectedTab = this.tabpagRegistro;
					this.panelRegister.Enabled = false;
					this._objMaterial = new tMaterial();
				}
			}
			else
			{
				if (this._cMaterial.Update(this._codMaterial))
				{
					this.dgvListado.CurrentRow.Cells[1].Value = this._objMaterial.Description + "" + "_" +
																this._objMaterial.Marca.Name  + "" + "_" +
																this._objMaterial.Model;

					this.dgvListado.CurrentRow.Cells[2].Value = this._objMaterial.Category.Name;
					this.dgvListado.CurrentRow.Cells[3].Value = "Buen Estado";
					this.dgvListado.CurrentRow.Cells[4].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

					this.pgsLoad.Visible = false;

					MetroMessageBox.Show(this, "El Material a sido Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question);

					this.ResetControls();
					this.tabpageMain.SelectedTab = this.tabpagMaterial;
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar Modificar el Modeficar", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.tabpageMain.SelectedTab = this.tabpagRegistro;
					this._objMaterial = new tMaterial();
				}
			}

			this._hilo.Abort();
		}

		private void FindMaterial()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._objMaterial = this._cMaterial.Find(this._codMaterial);

			if (this._objMaterial != null)
			{
				this.txtDescripcion.Text     = this._objMaterial.Description;
				this.cboCategoria.Text	     = this._objMaterial.Category.Name;
				this.cboMarca.Text           = this._objMaterial.Marca.Name;

				this.txtModelo.Text		     = this._objMaterial.Model;
				this.txtCostoReparacion.Text = Convert.ToString(this._objMaterial.RestorationCost);
				this.txtObservaciones.Text   = this._objMaterial.Observation;

				this.pgsLoad.Visible         = false;
				this.panelRegister.Enabled   = true;
				this.panelSearch.Enabled     = true;
				this.txtDescripcion.Focus();
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cMaterial.MsERegistrarMaterial, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this._hilo.Abort();
		}

		//METODO ORIGINAL PARA LISTA MATERIAL

		private void LoadData()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._cMaterial.List(this._data);

			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"];

			this.dgvListado.Columns["Codigo"].Visible = false;
			this.dgvListado.Columns["Description"].HeaderText  = "Descripcion";
			this.dgvListado.Columns["Category"].HeaderText     = "Categoria";
			this.dgvListado.Columns["Modifieddate"].HeaderText = "Ult. Modificacion";

			this.dgvListado.Columns["Description"].FillWeight = 120;
			this.dgvListado.Columns["Category"].FillWeight = 60;
			this.dgvListado.Columns["Condicion"].FillWeight = 60;
			this.dgvListado.Columns["Modifieddate"].FillWeight = 60;

			this.panelMain.Enabled = true;
			this.pgsLoad.Visible = false;
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._cMaterial.Delete(this._codMaterial))
			{
				this.pgsLoad.Visible = false;
				this.dgvListado.Rows.RemoveAt(this.dgvListado.CurrentRow.Index);
				MetroMessageBox.Show(this, "El Material a sido Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question);

				if (this.dgvListado.Rows.Count > 0)
				{
					this.panelSearch.Enabled = true;
					this.btnEliminar.Enabled = true;
					this.btnNuevo.Enabled    = true;
					this.btnGuardar.Enabled  = true;
					this.txtFiltrar.Enabled  = true;
				}
				else
				{
					this.txtFiltrar.Enabled   = false;
					this.panelSearch.Enabled  = true;
					this.btnSalir.Enabled     = true;
					this.btnEliminar.Enabled  = false;
					this.btnNuevo.Enabled     = true;
					this.btnModificar.Enabled = false;
					this.btnGuardar.Enabled   = false;
				}
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cMaterial.MsERegistrarMaterial, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS
		void ActionForDelete()
		{
			if (this.dgvListado.CurrentRow.Selected)
			{
				DialogResult result = MetroMessageBox.Show(
					this,
					"Realmente Deseas Eliminar EL Material seleccionado?\nPresiona Ok para Eliminar...",
					"ADVERTENCIA",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning
				);

				if (result == DialogResult.OK)
				{
					this._hilo = new Thread(new ThreadStart(SubmitDelete));

					this.panelSearch.Enabled = false;
					this.btnbuscar.Enabled = false;
					this.pgsLoad.Visible = true;

					this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);

					this._hilo.Start();
				}
			}
			else
				return;
		}

		void ResetControls()
		{
			this.txtDescripcion.Clear();
			this.cboCategoria.Text = "Seleccione...";
			this.cboMarca.Text = "Seleccione...";
			this.txtModelo.Clear();
			this.txtCostoReparacion.Clear();
			this.txtObservaciones.Clear();

			this._gotoModify = false;
			this._cMaterial.DataMaterial = new tMaterial();
		}

		void GetMateriales()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadData));

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		void JoinData()
		{
			this._cMaterial.DataMaterial.Description = this.txtDescripcion.Text;

			//if es nuevo registro de categoria
			if (this._isNewCategoria)
				this._cMaterial.DataCategoria.Name = this.cboCategoria.Text;
			else
				this._cMaterial.DataCategoria.Codigo = this._codCategoria;

			if (this._isNewMarca)
				this._cMaterial.DataMarca.Name = this.cboMarca.Text;
			else
				this._cMaterial.DataMarca.Codigo = this._codMarca;

			this._cMaterial.DataMaterial.Model = this.txtModelo.Text;
			this._cMaterial.DataMaterial.RestorationCost = Convert.ToDecimal(this.txtCostoReparacion.Text);
			this._cMaterial.DataMaterial.Observation = this.txtObservaciones.Text;
		}

		void ActionForModification()
		{
			this._hilo = new Thread(new ThreadStart(this.FindMaterial));
			this._gotoModify = true;

			this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);

			this.panelSearch.Enabled = false;
			this.panelRegister.Enabled = false;
			this.btnbuscar.Enabled = false;
			this.pgsLoad.Visible = true;
			this.tabpageMain.SelectedTab = this.tabpagRegistro;
			
			this._hilo.Start();
		}
	
		private void TemCategoria()
		{	
			string[] Categorias = new string[3] { "Escritorio", "Mesas", "Oficina" };
			
			for (int i = 0; i < Categorias.Length; i++)
			{
				object[] d = new object[3]
				{
					( i + 1 ),
					Categorias[i],
					DateTime.Now
				};

				this._data.Tables["ListaCategoria"].Rows.Add(d);
			}
		}

		private void TemMarca()
		{
			string[] Marca = new string[3] { "Faver Castel", "Viccarbe", "Ebanis" };

			for (int i = 0; i < Marca.Length; i++)
			{
				object[] d = new object[3]
				{
					( i + 1 ),
					Marca[i],
					DateTime.Now
				};

				this._data.Tables["ListaMarca"].Rows.Add(d);
			}
		}

		private bool ValidateData()
		{
			if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
			{
				this.toltipValid.Show("Descripcion requerida", this.txtDescripcion, 3000);
				this.txtDescripcion.Focus();
				return false;
			}

			if (this.cboCategoria.Text == "Seleccione...")
			{
				this.toltipValid.Show("Categoria requerida", this.cboCategoria, 3000);
				this.cboCategoria.Focus();
				return false;
			}

			return true;
		}

		#endregion

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			this.tabpageMain.SelectedTab = this.tabpagRegistro;
			this.panelRegister.Enabled   = true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.panelRegister.Enabled   = false;
			this.ResetControls();
			this.tabpageMain.SelectedTab = this.tabpagMaterial;
		}

		private void frmRegistrarMaterial_Load(object sender, EventArgs e)
		{
			if (this.dgvListado.Rows.Count > 0)
				this.GetMateriales();
			else
				return;	
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if ( this.dgvListado.CurrentRow !=null)
				this.ActionForModification();
			else
				return;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!this.ValidateData()) return;

			this._hilo = new Thread(new ThreadStart(this.SubmitInsertOrUpdate));

			this.JoinData();
			this.panelRegister.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void txtDescripcion_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtDescripcion.Text))
				this.lblValidateDescripcion.Visible = true;
			else
				this.lblValidateDescripcion.Visible = false;
		}

		private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ComboBox cbo = (ComboBox)sender;
			this.lblValidateCategoria.Visible = false;

			try
			{
				string fill = "Name = '" + this.cboCategoria.Text.Trim() + "'";
				DataRow[] dt = this._data.Tables["ListaCategoria"].Select(fill);

				if (dt.Length > 0)
				{
					this._codCategoria = Convert.ToInt32(dt[0]["Codigo"]); ;
					this._isNewCategoria = false;
				}
				else
				{
					this._codCategoria= 0;
					this._isNewCategoria = true;
				}

				if (cbo.SelectedItem == null)
					this.lblValidateCategoria.Visible = true;
				else
					this.lblValidateCategoria.Visible = false;

				if (string.IsNullOrWhiteSpace(this.cboCategoria.Text.Trim()))
				{
					this.lblValidateCategoria.Visible = true;
					this.lblValidateCategoria.Enabled = false;
				}
				else
				{
					this.cboCategoria.Enabled = true;
					this.lblValidateCategoria.Visible = false;
				}
			}

			catch (Exception ex) { }
		}

		private void cboCategoria_KeyDown(object sender, KeyEventArgs e)
		{
			if (!Helper.solotexto((char)e.KeyCode) &&
					!Helper.solonumeros((char)e.KeyCode)
					&& e.KeyData != Keys.Back
					&& e.KeyData != Keys.Right
					&& e.KeyData != Keys.Left)
			{
				e.SuppressKeyPress = true;
				return;
			}

			ComboBox cbo = (ComboBox)sender;

			try
			{
				DataRow[] dt = this._data.Tables["ListaCategoria"].Select("Name = '" + cboCategoria.Text + "'");

				if (dt.Length > 0)
				{
					this._codCategoria = Convert.ToInt32(dt[0]["Codigo"]);
					this._isNewCategoria = false;
				}
				else
				{
					this._codCategoria = 0;
					this.cboCategoria.SelectedIndex = -1;
					this._isNewCategoria = true;
				}
			}
			catch (Exception ex) { }
		}

		private void frmRegistrarMaterial_Load_1(object sender, EventArgs e)
		{

			this.TemCategoria();
			this.cboCategoria.ValueMember   = "Codigo";
			this.cboCategoria.DisplayMember = "Name";
			this.cboCategoria.DataSource    = this._data.Tables["ListaCategoria"];
			this.cboCategoria.SelectedIndex = -1;
			this.cboCategoria.Text          = "Seleccione...";

			this.TemMarca();
			this.cboMarca.ValueMember       = "Codigo";
			this.cboMarca.DisplayMember     = "Name";
			this.cboMarca.DataSource        = this._data.Tables["ListaMarca"];
			this.cboMarca.SelectedIndex     = -1;
			this.cboMarca.Text              = "Seleccione...";

			this.GetMateriales();
		}

		private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
		{
			 ComboBox cbo = (ComboBox)sender;

			try
			{
				string fill = "Name = '" + this.cboMarca.Text + "'";
				DataRow[] dt = this._data.Tables["ListaMarca"].Select(fill);

				if (dt.Length > 0)
				{
					this._codCategoria = Convert.ToInt32(dt[0]["Codigo"]); ;
					this._isNewCategoria = false;
				}
				else
				{
					this._codCategoria = 0;
					this._isNewCategoria = true;
				}

				if (cbo.SelectedItem == null)
					this.lblValidateCategoria.Visible = true;
				else
					this.lblValidateCategoria.Visible = false;
				if (string.IsNullOrWhiteSpace(this.cboCategoria.Text.Trim()))
				{
					this.lblValidateCategoria.Visible = true;
					this.lblValidateCategoria.Enabled = false;
				}
				else
				{
					this.cboCategoria.Enabled = true;
					this.lblValidateCategoria.Visible = false;
				}
			}
			catch (Exception ex) { }
		}

		private void cboMarca_KeyDown(object sender, KeyEventArgs e)
		{
			if (!Helper.solotexto((char)e.KeyCode) &&
					!Helper.solonumeros((char)e.KeyCode)
					&& e.KeyData != Keys.Back
					&& e.KeyData != Keys.Right
					&& e.KeyData != Keys.Left)
			{
				e.SuppressKeyPress = true;
				return;
			}

			ComboBox cbo = (ComboBox)sender;

			try
			{
				DataRow[] dt = this._data.Tables["ListaMarca"].Select("Name = '" + this.cboMarca.Text + "'");

				if (dt.Length > 0)
				{
					this._codMarca = Convert.ToInt32(dt[0]["Codigo"]);
					this._isNewMarca = false;
				}
				else
				{
					this._codMarca = 0;
					this.cboMarca.SelectedIndex = -1;
					this._isNewMarca = true;
				}
			}
			catch (Exception ex) { }
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.dgvListado.Rows.Count > 0)
				this.ActionForDelete();
		}

		private void txtFiltrar_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			this._data.Tables["ListaMaterial"].DefaultView.RowFilter = ("Description + ' ' + Category Like '%" + this.txtFiltrar.Text + "%'");
			this.dgvListado.DataSource = this._data.Tables["ListaMaterial"].DefaultView;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}
	}
}
