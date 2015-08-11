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
using  Objects.Tables;
using MaterialControl.ControlMaterial;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmDetalleIngresos : MetroForm
	{
		private Thread _hilo;
		private int _codigoMaterial;
		private int _codigoIngreso;

		Adquisicion _cAdquisicion = new Adquisicion();
		DataTable _dt = new DataTable();

		tKardex _objkardex = new tKardex();

		#region HILOS

		private void UpdateCostoIngreso()
		{
			CheckForIllegalCrossThreadCalls = false;
			if (this._cAdquisicion.UpdateQuantityIngresosOfMaterial(this._codigoMaterial, this._codigoIngreso))
			{
				MessageBox.Show("Cantidad Actualizada");

				DataRow[] datos = this._dt.Select("Codigo=" + _codigoMaterial);
				DataRow row = datos[0];
				this._dt.Rows[this._dt.Rows.IndexOf(row)][4] = this.nudCantidad.Value;
				this.Close();
			}
			else
				MessageBox.Show("Error : Cantidad No Actualizada");
		}

		private void LoadDetalle()
		{
			CheckForIllegalCrossThreadCalls = false;

			this._objkardex = this._cAdquisicion.Find(this._codigoMaterial,this._codigoIngreso);

			if (_objkardex != null)
			{
				this.txtTipoIngreso.Text     = (this._objkardex.Type) ? "Compra" : "Donacion";
				this.txtFechaIngreso.Text    = this._objkardex.PurchaseDate;
				this.txtNumeroDocumento.Text = this._objkardex.SerialNumber;
				this.nudCantidad.Text		 = this._objkardex.Quantity.ToString();
				this.txtCosto.Text			 = this._objkardex.PurchasePrice.ToString();
			
				this.panelMain.Enabled = true;
				this.btnModificar.Enabled = true;
				this.pgsLoad.Visible = false;		
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS
		private void JoinData()
		{
			if (this.nudCantidad.Value != this._objkardex.Quantity)
			{
				this._cAdquisicion.Data.Quantity = Convert.ToInt32(this.nudCantidad.Value);
				this._cAdquisicion.Data.ModifiedDate = DateTime.Now.ToString();
			}
		}

		#endregion

		public frmDetalleIngresos(int CodigoIngreso, int CodigoMaterial, DataTable dt)
		{
			this._codigoIngreso = CodigoIngreso;
			this._codigoMaterial = CodigoMaterial;
			InitializeComponent();
			this._dt = dt;

		}

		private void cboIngresos_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void frmDetalleIngresos_Load(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.LoadDetalle));

			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{

			this._hilo = new Thread(new ThreadStart(this.UpdateCostoIngreso));
			if (nudCantidad.Value == 0)
				this.toolTipValidacion.Show("Minimo un Material", this.nudCantidad, 300);
			else
				this.JoinData();
			this._hilo.Start();
		}

		private void txtTipoIngreso_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}
	}
}
