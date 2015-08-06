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
using System.Threading;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class mdlReporte : MetroForm
	{
		private int _codigoMaterial;
		private string _nombreMaterial;

		private Materiales _cMaterial = new Materiales();
		private ReportarMaterial _cReportarMaterial = new ReportarMaterial();

		private tReportarMaterial _objReportMaterial = new tReportarMaterial();

		private Thread _hilo;

		DataTable _dt = new DataTable();

		public mdlReporte(int codigo , string nombre)
		{
			InitializeComponent();
			this._codigoMaterial = codigo;
			this._nombreMaterial = nombre;
		}

		#region PROPIEDADES

		public int Codigo
		{
			get { return this._codigoMaterial; }
			set { this._codigoMaterial = value; }
		}

		#endregion

		#region HILOS

		private void ReportdMaterialSelected()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._codigoMaterial > 0)
			{
				this.txtDescripcion.Text = this._nombreMaterial;

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

		private void SubmitInsert()
		{
			CheckForIllegalCrossThreadCalls = false;

				int codigo = this._cReportarMaterial.Insert();

				if (codigo > 0)
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Reporte registrado Satisfactoriamente", "Correcto",
					MessageBoxButtons.OK, MessageBoxIcon.Question);
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
			this._objReportMaterial.CodigoMaterial = this._codigoMaterial;
			this._objReportMaterial.Condicion      = this.cboCondicion.Text;
			this._objReportMaterial.Responsable    = this.txtResponsable.Text; 


			this._cReportarMaterial.Data = this._objReportMaterial;
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
			this._hilo = new Thread(new ThreadStart(this.SubmitInsert));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible   = true;

			this._hilo.Start();
		}
	}
}
