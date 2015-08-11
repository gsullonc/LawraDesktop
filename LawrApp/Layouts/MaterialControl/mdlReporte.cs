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
using Objects.Tables;
using Objects.Processes;
using System.Threading;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class mdlReporte : MetroForm
	{
		private int    _codigoMaterial;
		private string _nombreMaterial;
		private int	   _codigoSalon;
		private string _condicion;
		private Materiales _cMaterial = new Materiales();

		public delegate void getCondicionMaterial(int CodigoMaterial, string Condicion);
		public event getCondicionMaterial UpdateCondicionMaterial;

		private ReportarMaterial _cReportarMaterial = new ReportarMaterial();

		private lMaterial _ListReportMaterial = new lMaterial();

		private Thread _hilo;

		DataTable _dt = new DataTable();

		public mdlReporte( int CodigoSalon,int CodigoMaterial , string nombre, string condicion)
		{
			InitializeComponent();

			this._codigoMaterial = CodigoMaterial;
			this._nombreMaterial = nombre;
			this._codigoSalon    = CodigoSalon;
			this._condicion      = condicion;
		}

		#region HILOS

		private void ReportdMaterialSelected()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._codigoMaterial > 0)
			{
				this.txtDescripcion.Text = this._nombreMaterial;
				if(this._condicion == "Req. Reparacion" )
					this.cboCondicion.Items.RemoveAt(0);
		
				this.pgsLoad.Visible = false;
				this.panelMain.Enabled = true;
			}
			else
			{
				MetroMessageBox.Show(this, " informacion no encontrada", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}

			this._hilo.Abort();
		}

		private void SubmitUpdate()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._cReportarMaterial.Update(this._codigoMaterial,this._codigoSalon))
			{
				this.pgsLoad.Visible = false;

				MetroMessageBox.Show(this, "Reporte creado Satisfactoriamente", "Correcto",
				MessageBoxButtons.OK, MessageBoxIcon.Question);

				UpdateCondicionMaterial(_codigoMaterial,this.cboCondicion.Text);

				this.ResetControls();
				this.Close();
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, "Faill al registrar Reporte ", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

				this.panelMain.Enabled = false;	
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ResetControls() 
		{
			this.txtDescripcion.Text = string.Empty;
			this.cboCondicion.Text   = string.Empty;
			this.txtResponsable.Text = string.Empty;
			this.txtDetalle.Text     = string.Empty;
		}

		void JoinData()
		{
			this._ListReportMaterial.Condicion = this.cboCondicion.Text;
		}

		#endregion

		private void cboCondicion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void mdlReporte_Load(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.ReportdMaterialSelected));
			
			this.pgsLoad.Visible   = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		private void btnguardar_Click(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.SubmitUpdate));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible   = true;
			
			this._hilo.Start();
		}
	}
}
