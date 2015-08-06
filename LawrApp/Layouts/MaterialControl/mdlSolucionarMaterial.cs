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
using Objects.Processes;


namespace LawrApp.Layouts.MaterialControl
{
	public partial class mdlSolucionarMaterial : MetroForm
	{
		private int _codigo;
		private string _name;
	
		SolucionarMaterial _cSolucionarMaterial = new SolucionarMaterial();
		Materiales _cMaterial = new Materiales();
		tSolucionarMaterial _objSolucionMatrial = new tSolucionarMaterial();

		private Thread _hilo;
		private bool _gotoModify = false;

		DataTable _dt = new DataTable();

		public mdlSolucionarMaterial(int codigo, string name, DataTable dt)
		{
			this._dt = dt;
			InitializeComponent();
			this._codigo = codigo;
			this._name = name;
		}
 
		#region HILOS

		private void Selected()
		{
			CheckForIllegalCrossThreadCalls = false;

			if (this._codigo > 0)
			{
				this.txtDescripcion.Text = _name;

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

			if (!this._gotoModify)
			{
				int codigo = this._cSolucionarMaterial.Insert();

				if (codigo > 0)
				{
					
					DataRow[] material = this._dt.Select("Codigo=" + codigo);
					material[0]["Condicion"] = " Buen Estado";
					
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Material Solucionado", "Correcto",
					MessageBoxButtons.OK, MessageBoxIcon.Question);

					this.ResetControls();
				}
				else
				{
					this.pgsLoad.Visible = false;
					MetroMessageBox.Show(this, "Error al intentar registrar Solucion", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				}
			}

			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		void ResetControls()
		{
			this.txtDescripcion.Text = string.Empty;
			this.dtpF_Solucion.Value = DateTime.Now;
			this.txtObervacion.Text  = string.Empty;
		}

		void JoinData()
		{
			this._objSolucionMatrial.CodigoMaterial = this._codigo;
			this._objSolucionMatrial.DateSolucion   = this.dtpF_Solucion.Text;
			this._objSolucionMatrial.Obsevation     = this.txtObervacion.Text;
  
			this._cSolucionarMaterial.Data = this._objSolucionMatrial;
		}

		#endregion

		private void mdlSolucionarMaterial_Load(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.Selected));
			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;
			this._hilo.Start();
		}

		private void btngGuardar_Click(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.SubmitInsert));

			this.JoinData();
			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

	}
}
