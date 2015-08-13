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
using Objects.Processes;
using MaterialControl.ControlMaterial;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class mdlSearch : MetroForm
	{
		Materiales _cMaterial = new Materiales();
		DataGeneral _dts = new DataGeneral();
		lMaterial _ListadoMaterial = new lMaterial();
		private Thread _hilo;

		public delegate void getMaterial(int Codigo,
										 string Descripcion,
										 string Categoria, 
										 string Marca,
										 string Modelo,
										 string Key);

		public event getMaterial SendMaterial;

		public mdlSearch(DataGeneral dts)
		{
			this._dts = dts;
			InitializeComponent();
		}

		#region HILOS

		private void LoadDataMaterial()
		{
			CheckForIllegalCrossThreadCalls = false;
			this._cMaterial.List(this._dts);

			this.dgvListado.DataSource = this._dts.Tables["ListaMaterial"];

			this.dgvListado.Columns["Codigo"].Visible       = false;
			this.dgvListado.Columns["Condicion"].Visible    = false;
			this.dgvListado.Columns["C_value"].Visible		= false;
			this.dgvListado.Columns["Modifieddate"].Visible = false;

			this.dgvListado.Columns["Description"].HeaderText = "Descripcion";
			this.dgvListado.Columns["Category"].HeaderText    = "Categoria";

			this.dgvListado.Columns["Description"].FillWeight = 120;
			this.dgvListado.Columns["Key"].FillWeight         = 40;
			this.dgvListado.Columns["Category"].FillWeight    = 60;
			this.dgvListado.Columns["Condicion"].FillWeight   = 60;

			this.panelMain.Enabled = true;
			this.pgsLoad.Visible   = false;
		}
				
		private void SendToAdquisicion()
		{
			CheckForIllegalCrossThreadCalls = false;
					
			IMateriales iterfazMaterial = this.Owner as IMateriales;

			int index = this.dgvListado.CurrentCell.RowIndex;

			int Codigo = Convert.ToInt32(this.dgvListado.Rows[index].Cells[0].Value);

			string NombreMaterial = "sdsds";
			string Categoria = "sddsa";
			string Marca = "sdasdas";
			string Modelo = "dsd";

			if (iterfazMaterial != null)
			{
				iterfazMaterial.AddMaterial(Codigo, NombreMaterial, Categoria, Marca, Modelo);
				this.Close();
			}

		}

		#endregion

		#region METODOS
		void GetMateriales()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadDataMaterial));

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
		}

		#endregion

		private void mdlSearch_Load(object sender, EventArgs e)
		{
			this.GetMateriales();
		}

		private void txtfiltro_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			this._dts.Tables["ListaMaterial"].DefaultView.RowFilter = ("Description + ' ' + Category Like '%" + this.txtfiltro.Text + "%'");
			this.dgvListado.DataSource = this._dts.Tables["ListaMaterial"].DefaultView;
		}

		private void dgvListado_KeyDown(object sender, KeyEventArgs e)
			{
			if(e.KeyData == Keys.Enter)
			{
				if (this.dgvListado.Rows.Count > 0)
				{
					if (this.dgvListado.Rows.Count > 0)
					{
						this._hilo = new Thread(new ThreadStart(this.SendToAdquisicion));
						this._hilo.Start();
					}
				}
			}

		}

		private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvListado.CurrentRow.Selected)
			{
				int index = this.dgvListado.CurrentCell.RowIndex;

				int codigo = Convert.ToInt32(this.dgvListado.Rows[index].Cells[0].Value);
				string key = Convert.ToString(this.dgvListado.Rows[index].Cells[1].Value);
				string descripcion = Convert.ToString(this.dgvListado.Rows[index].Cells[2].Value);
				string Marca = "d";
				string categoria = Convert.ToString(this.dgvListado.Rows[index].Cells[3].Value);
				string Modelo = "Ovalada";

				this.SendMaterial(codigo, descripcion, categoria, Marca, Modelo,key);

				this.Dispose();
			}
			else
				return;
		}
	}
}
