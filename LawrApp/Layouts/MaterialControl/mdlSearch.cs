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
		Adquisicion _cAdquisicion = new Adquisicion();

		DataGeneral _dts = new DataGeneral();
		lMaterial _ListadoMaterial = new lMaterial();

		DataTable _dt2 = new DataTable();

		private Thread _hilo;


		public delegate void getMaterial(int Codigo,
										 string Descripcion,
										 string Categoria, 
										 string Marca,
										 string Modelo,
										 int Cantidad
										 );

		public event getMaterial SendMaterial;

		public mdlSearch(DataGeneral dts)
		{
			this._dts = dts;
			InitializeComponent();
		}

		#region HILOS
				
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

		private void LoadDataIngresos()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lIngresos> lingreso = this._cAdquisicion.ListIngresos();

			if (lingreso.Count > 0)
			{
				foreach (lIngresos item in lingreso)
				{
					object[] dataMaterial = this._dts.Tables["ListaMaterial"].Select("Codigo=" + item.CodigoMaterial)[0].ItemArray;

					string Descripcion = Convert.ToString(dataMaterial[1]);
					string Categoria = Convert.ToString(dataMaterial[2]);

					object[] ingresos = new object[6]
					 {
						item.Codigo,
						item.CodigoMaterial,
						item.Key,
						Descripcion,
						Categoria,
						item.Quantity
					 };

					this._dt2.Rows.Add(ingresos);
				}

				this.dgvListado.DataSource = _dt2;

				this.dgvListado.Columns[0].Visible = false;
				this.dgvListado.Columns[1].Visible = false;
				this.dgvListado.Columns[2].Visible = false;

				this.dgvListado.Columns[3].FillWeight = 150;
				this.dgvListado.Columns[4].FillWeight = 50;
				this.dgvListado.Columns[5].FillWeight = 45;

				this.panelMain.Enabled = true;

				this.dgvListado.ClearSelection();

				this.pgsLoad.Visible = false;
			}
			else
			{
				MetroMessageBox.Show(this, "No se ha encontrado Informacion ", "lISTA INGRESOS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		#endregion

		#region METODOS
		private void PasarMaterial()
		{

			if (dgvListado.CurrentRow.Selected)
			{
				int index = this.dgvListado.CurrentCell.RowIndex;

				int codigo = Convert.ToInt32(this.dgvListado.Rows[index].Cells[0].Value);
				string descripcion = Convert.ToString(this.dgvListado.Rows[index].Cells[3].Value);
				string categoria = Convert.ToString(this.dgvListado.Rows[index].Cells[4].Value);
				string Marca = "d";
				string Modelo = "Ovalada";
				int Cantidad = Convert.ToInt32(this.dgvListado.Rows[index].Cells[5].Value);

				this.SendMaterial(codigo, descripcion, categoria, Marca, Modelo,Cantidad);

				this.Dispose();
			}
			else
				return;
		}

		private void ColumnListIngresos()
		{
			this._dt2.Columns.Add("Codigo", typeof(string));
			this._dt2.Columns.Add("Codigo_Material", typeof(string));
			this._dt2.Columns.Add("Key", typeof(string));
			this._dt2.Columns.Add("Descripcion", typeof(string));
			this._dt2.Columns.Add("Categoria", typeof(string));
			this._dt2.Columns.Add("Cantidad", typeof(string));
		}

		#endregion

		private void mdlSearch_Load(object sender, EventArgs e)
		{
			this.panelMain.Enabled = false;

			this.ColumnListIngresos();

			this._hilo = new Thread(new ThreadStart(this.LoadDataIngresos));

			this.panelMain.Enabled = false;
			this.pgsLoad.Visible = true;

			this._hilo.Start();
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
			this.PasarMaterial();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.PasarMaterial();
		}
	}
}
