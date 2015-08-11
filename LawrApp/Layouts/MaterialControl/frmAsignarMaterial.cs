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
using System.Threading;
using MaterialControl.ControlMaterial;
using Objects.Tables;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmAsignarMaterial : MetroForm
	{
		DataGeneral    _data;

		AsignarMaterial _cAsignarMaterial = new AsignarMaterial();
		tMaterial _objMaterialofAula = new tMaterial();	

		private Thread _hilo;
		private bool _gotoModify;
		private int _codMaterial;

		public frmAsignarMaterial( DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			mdlSearch search = new mdlSearch(this._data);
			search.SendMaterial += new mdlSearch.getMaterial(this.ObtenerDataOfMaterial);
			search.ShowDialog();
		}

		#region HILOS

		private void SubmitInsertOrUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (!this._gotoModify)
			{
				int codigo = this._cAsignarMaterial.Insert();

				if (codigo > 0)
				{
					this.pgsLoad.Visible = false;

					this.dgvListado.Rows.Add();
					this.dgvListado.Rows[0].Cells[0].Value = this.cboSalones.SelectedValue;
					this.dgvListado.Rows[0].Cells[1].Value = this._codMaterial;
					this.dgvListado.Rows[0].Cells[2].Value = this.txtDescripcion.Text;
					this.dgvListado.Rows[0].Cells[3].Value = this.nudCantidad.Value;
					
					this.ResetControls();

					if (dgvListado.Rows.Count > 0)
						this.btnEliminar.Enabled = true;
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar registrar al Material", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
	
					this.panelMain.Enabled = true;
					this._cAsignarMaterial.Data = new tMaterialSalon();
				}
			}
			else
			{
				if (this._cAsignarMaterial.Update(this._codMaterial, Convert.ToInt32(this.dgvListado.Rows[0].Cells[0].Value)))
				{
					this.dgvListado.CurrentRow.Cells[3].Value = this.nudCantidad.Value;
					this.pgsLoad.Visible = false;

					MetroMessageBox.Show(this, "El Material a sido Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question);
					this.panelMain.Enabled = true;
					this.nudCantidad.Value = 1;
					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar Modificar al apoderado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this._cAsignarMaterial.Data = new tMaterialSalon();
				}
			}

			this._hilo.Abort();
		}

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;


			if (this._cAsignarMaterial.Delete(this._codMaterial, Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value) ))
			{
				this.pgsLoad.Visible = false;
				this.dgvListado.Rows.RemoveAt(this.dgvListado.CurrentRow.Index);
				this.btnEliminar.Enabled = false;
				MetroMessageBox.Show(this, "El Material a sido Eliminado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cAsignarMaterial.MsgExeption, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
				this.txtDescripcion.Text      = this._objMaterialofAula.Description;
				this.txtCategoria.Text        = this._objMaterialofAula.Category.Name;
				this.txtMarca.Text			  = this._objMaterialofAula.Marca.Name;
				this.txtModelo.Text           = this._objMaterialofAula.Model;

				this.nudCantidad.Value = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[3].Value); 

				this.pgsLoad.Visible = false;
				this.cboSalones.Enabled = false;
				this.btnAgregar.Enabled = true;

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

					this.btnbuscar.Enabled = false;
					this.pgsLoad.Visible = true;

					this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);

					this._hilo.Start();
				}
			}
			else
				return;
		}

		private void ObtenerDataOfMaterial(int Codigo, string Descripcion, string Categoria, string Marca, string Modelo)
		{
			this._codMaterial		 = Convert.ToInt32(Codigo);
			this.txtDescripcion.Text = Descripcion;
			this.txtMarca.Text       = Marca;
			this.txtCategoria.Text   = Categoria;
			this.txtModelo.Text      = Modelo;

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
			this.btnbuscar.Enabled   = false;
			this.btnAgregar.Enabled  = false;
		}

		private void JoinData()
		{
			this._cAsignarMaterial.Data.CodigoMaterial = this._codMaterial;
			this._cAsignarMaterial.Data.CodigoSalon	   = Convert.ToInt32(this.cboSalones.SelectedValue);
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
	

		#endregion

		private void frmAsignarMaterial_Load(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.DataAulas));
			this.cboSalones.Enabled = false;
			this.pgsLoad.Visible = true;
			this._hilo.Start();
		}

		private void txtMarca_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void cboSalones_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.txtDescripcion.Enabled = true;
			this.btnbuscar.Enabled = true;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.SubmitInsertOrUpdate));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgvListado.CurrentRow.Selected)
				this.ActionForModification();
			else
				return;

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.dgvListado.Rows.Count > 0)
				this.ActionForDelete();
		}
	}
}
