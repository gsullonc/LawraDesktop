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
using MaterialControl.ControlMaterial;
using System.Threading;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmIngresos : MetroForm, IMateriales
	{
		Adquisicion    _cAdqusicion = new Adquisicion();
		DataGeneral    _dts;
		private Thread _hilo;

		private  int   _codMaterial;

		public frmIngresos(DataGeneral dts)
		{
			this._dts = dts;
			InitializeComponent();
		}

		#region HILOS

		private void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;
		
				int codigo = this._cAdqusicion.Insert();

				if (codigo > 0)
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "La Adquisicion se ha registrado correctamente", "Correcto",
					MessageBoxButtons.OK, MessageBoxIcon.Question);

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar registrar una adquisicion", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS DE INTERFAZES

		public void AddMaterial(int codigo, string descripcion, string categoria, string marca, string modelo)
		{
			this.txtDescripcion.Text = descripcion;
			this.txtCategoria.Text = categoria;
			this.txtMarca.Text = marca ;
			this.txtModelo.Text = modelo;
			this._codMaterial = codigo;

			this.cboTipoIngreso.Enabled = true;
		}

		#endregion

		#region METODOS QUE USA DELEGADOS

		private void ObtenerDataOfMaterial(int Codigo, string Descripcion, string Categoria, string Marca, string Modelo)
		{
			this._codMaterial           = Codigo;
			this.txtDescripcion.Text    = Descripcion;
			this.txtMarca.Text          = Marca;
			this.txtCategoria.Text      = Categoria;
			this.txtModelo.Text         = Modelo;

			this.cboTipoIngreso.Text = "Seleccione...";

			this.txtDescripcion.Enabled = true;
			this.btnGuardar.Enabled     = true;
			this.cboTipoIngreso.Enabled = true;

			
		}

		#endregion


		#region METODOS

		private void ResetControls()
		{
			this.txtDescripcion.Clear();
			this.txtCategoria.Clear();
			this.txtMarca.Clear();
			this.txtModelo.Clear();
			this.txtCosto.Clear();
			this.txtNªDocumento.Clear();

			this.cboTipoIngreso.Text = "Seleccione...";

			this.btnbuscar.Enabled = true;
			this.nudCantidad.Value = 1;

			this.lblValidateFecha_Compra.Visible = false;
			this.lblValidateCosto.Visible		 = false;
			this.lblValidateCantidad.Visible     = false;
			this.lblValidateNº_Documento.Visible = false; 
		}
		
		private bool ValidateData()
		{
			if (this.cboTipoIngreso.Text == "Seleccione...")
			{
				this.toltipValid.Show("Tipo de Ingreso requerida", this.cboTipoIngreso, 3000);
				this.cboTipoIngreso.Focus();
				return false;
			}

			if(this.txtCosto.Enabled)
			{
				if(string.IsNullOrEmpty(this.txtCosto.Text))
				{
					this.toltipValid.Show("Costo requerido", this.txtCosto, 3000);
					this.txtCosto.Focus();
					return false;
				}
			}

			if (this.nudCantidad.Enabled)
			{
				if (this.nudCantidad.Value == 0)
				{
					this.toltipValid.Show("Minimo un Material requerido", this.nudCantidad, 3000);
					this.txtCosto.Focus();
					return false;
				}
			}

			if (this.txtNªDocumento.Enabled)
			{
				if (string.IsNullOrEmpty(this.txtNªDocumento.Text))
				{
					this.toltipValid.Show("Numero de documentos requerido", this.txtCosto, 3000);
					this.txtNªDocumento.Focus();
					return false;
				}
			}

			return true;
		}

		private void JoinData()
		{
			this._cAdqusicion.Data.CodigoMaterial = this._codMaterial;
			this._cAdqusicion.Data.Type			  = (this.cboTipoIngreso.Text == "Compra") ? true: false ;
			
			if(this._cAdqusicion.Data.Type)
			{
				this._cAdqusicion.Data.Quantity      = Convert.ToInt32(this.nudCantidad.Value);
				this._cAdqusicion.Data.PurchaseDate  = this.dtpFecha_Compra.Text;
				this._cAdqusicion.Data.PurchasePrice = Convert.ToInt32(this.txtCosto.Text);
				this._cAdqusicion.Data.SerialNumber  = this.txtNªDocumento.Text;
			}
			else
				this._cAdqusicion.Data.SerialNumber = this.txtNªDocumento.Text;
		}

		#endregion

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			mdlSearch search = new mdlSearch(this._dts);
			search.SendMaterial += new mdlSearch.getMaterial(this.ObtenerDataOfMaterial);
			search.ShowDialog();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!this.ValidateData()) return;

			this._hilo = new Thread(new ThreadStart(this.SubmitInsert));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible   = true;

			this._hilo.Start();
		}

		private void cboTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTipoIngreso.SelectedIndex == 0)
			{
				this.txtCosto.Enabled                = false;
				this.nudCantidad.Enabled             = false;
				this.dtpFecha_Compra.Enabled         = false;

				this.lblValidateFecha_Compra.Visible = false;
				this.lblValidateCantidad.Visible	 = false;
				this.lblValidateCosto.Visible		 = false;
				this.lblValidateNº_Documento.Visible = false;

				this.txtNªDocumento.Enabled          = true;
			}
			else
			{
				this.txtCosto.Enabled		 = true;
				this.nudCantidad.Enabled	 = true;
				this.dtpFecha_Compra.Enabled = true;
				this.txtNªDocumento.Enabled  = true;
				this.nudCantidad.Enabled     = true;

				this.nudCantidad.Value = 1;

				this.lblValidateFecha_Compra.Visible = true;
				this.lblValidateCosto.Visible        = true;
				this.lblValidateCantidad.Visible     = true;
				this.lblValidateNº_Documento.Visible = true;

			}
		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._dts);
			main.Show();
			this.Close();
		}

		private void cboTipoIngreso_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.lblValidateTipoIngreso.Visible = false;
		}

		private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void txtCosto_TextChanged(object sender, EventArgs e)
		{
			if( string.IsNullOrEmpty(this.txtCosto.Text))
				this.lblValidateCosto.Visible = true;
			else
				this.lblValidateCosto.Visible = false;

			if ( this.nudCantidad.Value == 0)
				this.lblValidateCantidad.Visible = true;
			else
				this.lblValidateCantidad.Visible = false;

			if (string.IsNullOrEmpty(this.txtNªDocumento.Text))
				this.lblValidateNº_Documento.Visible = true;
			else
				this.lblValidateNº_Documento.Visible = false;

		}
	}
}
