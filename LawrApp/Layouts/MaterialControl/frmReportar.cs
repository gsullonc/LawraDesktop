using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Objects.Processes;
using MaterialControl.ControlMaterial;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmReportar : MetroForm
	{
		private DataGeneral _data;
		private DataTable _dt = new DataTable();
		private Thread _hilo;
		private Materiales _cMaterial = new Materiales();

		private int _codAula;
		public frmReportar(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region HILOS

		private void LoadMaterialOfAula()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lMaterial> lista = this._cMaterial.ListforAula(this._codAula);
		
			if (lista != null && lista.Any())
			{
				foreach (lMaterial item in lista)
				{
					string conditionString = string.Empty;

					switch( item.Condicion )
					{
						case "A": conditionString = "En Buen Estado"; break;
						case "B": conditionString = "Req. Reparacion"; break;
						case "C": conditionString = "En Pesimo Estado"; break;
					}

					object[] obj = new object[5] 
					{
						item.Codigo,
						item.Description + " " + "_" + item.Marca + " " + "_" + item.Model,
						item.Category,
						conditionString,
						item.Condicion
					};

					this._dt.Rows.Add(obj);
				}

				this.dgvListado.DataSource = this._dt;

				this.dgvListado.Columns["Codigo"].Visible = false;
				this.dgvListado.Columns["C_Value"].Visible = false;

				this.dgvListado.Columns["Categoria"].FillWeight = 50;
				this.dgvListado.Columns["Condicion"].FillWeight = 50;

				this.pgsLoad.Visible = false;
				this.dgvListado.Enabled = true;

				this.cboTipoBusqueda.ValueMember = "Codigo";
				this.cboTipoBusqueda.DisplayMember = "Nombre";
				this.cboTipoBusqueda.DataSource = this.TempEstadoMaterial();
				this.cboTipoBusqueda.SelectedValue = "All";
				this.cboTipoBusqueda.Enabled = true;
				this.txtfiltro.Enabled = true;
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, "No hay Materiales Registrados", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			this.pgsLoad.Enabled = false;
			this.panel1.Enabled = true;
			this.btnReportar.Enabled = true;
			this.btnSolucionar.Enabled = true;

			this._hilo.Abort();
		}

		#endregion

		#region METODOS
		private void AgregarColumnDatatableGlobal()
		{
			this._dt.Columns.Add("Codigo",typeof(int));
			this._dt.Columns.Add("Descripcion", typeof(string));
			this._dt.Columns.Add("Categoria", typeof(string));
			this._dt.Columns.Add("Condicion", typeof(string));
			this._dt.Columns.Add("C_Value",typeof(string));
		}

		private void GetMaterialesOneAula()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadMaterialOfAula));
			this._codAula = Convert.ToInt32(this.cboSalon.SelectedValue);
			this.pgsLoad.Visible = true;
			this.panel1.Enabled = false;

			this._hilo.Start();
		}
			
		private void DataAulas()
		{
			string[] Aulas = new string[3] { "Semillitas del saber", "Nº 1", "Nº 2" };
			
			for (int i = 0; i < Aulas.Length; i++)
			{
				object[] d = new object[2]
				{
					( i + 1 ),
					Aulas[i]
				};

				this._data.Tables["ListaSalones"].Rows.Add(d);
			}
		}

		private DataTable TempEstadoMaterial()
		{
			DataTable dtMaterial = new DataTable();

			dtMaterial.Columns.Add("Codigo", typeof(string));
			dtMaterial.Columns.Add("Nombre", typeof(string));

			string[] Codigo = new string[4] { "All" ,"A","B" , "C"};
			string[] Nombre = new string[4] { "Todo","Buen Estado","Req. Reparacion", "Pesimo" };

			for (int i = 0; i < Codigo.Length; i++)
			{
				object[] d = new object[2]
				{
					Codigo[i],
					Nombre[i]
				};

				dtMaterial.Rows.Add(d);
			}
			return dtMaterial;
		}


		#endregion

		private void frmReportar_Load(object sender, EventArgs e)
		{
			this.AgregarColumnDatatableGlobal();
			this.DataAulas();

			//DENTRO DEL HLO TENGO QUE PONERLO Y TEGO QUE CONVERTIR TODAS LOS ETDOS QUE SE COMUNICAN CON EL SERVIDOR EN HILOS
			this.cboSalon.ValueMember = "Codigo";
			this.cboSalon.DisplayMember = "Descripcion";
			this.cboSalon.DataSource = this._data.Tables["ListaSalones"];
			this.cboSalon.SelectedIndex = -1;
			this.cboSalon.Text = "Seleccione...";

			this.dgvListado.Enabled = false;
			this.btnSolucionar.Enabled = false;
			this.btnReportar.Enabled = false;
		}

		private void cboSalon_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.GetMaterialesOneAula();
		}

		private void dgvListado_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int posicion_row_Mause = this.dgvListado.HitTest(e.X, e.Y).RowIndex;

				if (posicion_row_Mause >= 0)
				{
					this.dgvListado.Rows[posicion_row_Mause].Selected = true;
					this.dgvListado.CurrentCell = this.dgvListado.Rows[posicion_row_Mause].Cells[1];
					this.cmsOptions.Show(this.dgvListado, new Point(e.X, e.Y));
				}
			}
		} 

		private void rEPORTARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int codigoMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);
			string nombreMaterial = Convert.ToString(this.dgvListado.CurrentRow.Cells[1].Value);

			mdlReporte reporte = new mdlReporte(codigoMaterial,nombreMaterial);
			reporte.Codigo = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);
			reporte.ShowDialog();
		}

		private void tsmItemSolucionar_Click(object sender, EventArgs e)
		{
			int codigo = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);
			string nombreMaterial = Convert.ToString(this.dgvListado.CurrentRow.Cells[1].Value);

			mdlSolucionarMaterial solucionar = new mdlSolucionarMaterial(codigo,nombreMaterial, this._dt);
			solucionar.ShowDialog();
		}

		private void txtfiltro_TextChanged(object sender, EventArgs e)
		{
				if( this.cboTipoBusqueda.SelectedValue.ToString() == "All" )
				{
					this._dt.DefaultView.RowFilter = ("Descripcion + ' ' + Categoria like '%" + this.txtfiltro.Text + "%'");
					this.dgvListado.DataSource = this._dt.DefaultView;
				}
				else
				{
					this._dt.DefaultView.RowFilter = ("Descripcion + ' ' + Categoria like '%" + this.txtfiltro.Text + "%' AND C_Value='" + this.cboTipoBusqueda.SelectedValue.ToString() + "'");
					this.dgvListado.DataSource = this._dt.DefaultView;
				}
		}

		private void cboTipoBusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void cboTipoBusqueda_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if ( this.cboTipoBusqueda.SelectedValue.ToString() != "All" )
			{
				this._dt.DefaultView.RowFilter = ("C_Value='" + this.cboTipoBusqueda.SelectedValue.ToString() + "'");
				this.dgvListado.DataSource = this._dt.DefaultView;
			}
			else
			{
				this._dt.DefaultView.RowFilter = string.Empty;
				this.dgvListado.DataSource = this._dt;
			}

			txtfiltro.Clear();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmMain main = new frmMain(this._data);
			main.Show();
			this.Close();
		}
	}
}
