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
				DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
				d.Name = "Seleccion";
				d.HeaderText = "Seleccion";

				foreach (lMaterial item in lista)
				{
					string conditionString = string.Empty;

					switch( item.Condicion )
					{
						case "A": conditionString = "En Buen Estado"; break;
						case "B": conditionString = "Req. Reparacion"; break;
						case "C": conditionString = "En Pesimo Estado"; break;
					}

					object[] obj = new object[6] 
					{
						item.Codigo,
						item.Key,
						item.Description + " " + "_" + item.Marca + " " + "_" + item.Model,
						item.Category,
						conditionString,
						item.Condicion
					};

					this._dt.Rows.Add(obj);
				}

				this.dgvListado.DataSource = this._dt;
				this.dgvListado.Columns.Add(d);

				this.dgvListado.Columns["Codigo"].Visible  = false;
				this.dgvListado.Columns["C_Value"].Visible = false;

				this.dgvListado.Columns[1].FillWeight			= 40;
				this.dgvListado.Columns[6].FillWeight			= 40;
				this.dgvListado.Columns["Key"].FillWeight       = 60;
				this.dgvListado.Columns["Categoria"].FillWeight = 50;
				this.dgvListado.Columns["Condicion"].FillWeight = 52;

				this.pgsLoad.Visible    = false;
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
				MetroMessageBox.Show(this, "No hay Materiales Registrados", "Info!", MessageBoxButtons.OK, 
				MessageBoxIcon.Information);
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
			this._dt.Columns.Add("Codigo",		typeof(int));
			this._dt.Columns.Add("Key",         typeof(string));
			this._dt.Columns.Add("Descripcion", typeof(string));
			this._dt.Columns.Add("Categoria",	typeof(string));
			this._dt.Columns.Add("Condicion",   typeof(string));
			this._dt.Columns.Add("C_Value",		typeof(string));
		}

		//Actualiza la condicion de un material que se ha reportado individualmente
		private void UpdateCondicionReportIndividual(int codMaterial, string condicion)
		{
			DataRow[] datos = this._dt.Select("Codigo=" + codMaterial);
			DataRow row = datos[0];
			this._dt.Rows[this._dt.Rows.IndexOf(row)][3] = condicion;
			
			switch(condicion)
			{
				case "Reg.Reparacion":
					this._dt.Rows[this._dt.Rows.IndexOf(row)][4] = "B";
					break;
				case "En Pesimo Estado":
					this._dt.Rows[this._dt.Rows.IndexOf(row)][4] = "C";
					break;
			}
			
			this.pgsLoad.Visible = false;
		}

		//Actualiza la condicion de un material que se ha solucionado
		private void UpdateCondicionSolucionIndividual(int codMaterial)
		{
			DataRow[] datos = this._dt.Select("Codigo=" + codMaterial);
			DataRow row = datos[0];
			this._dt.Rows[this._dt.Rows.IndexOf(row)][3] = "En Buen Estado";
			this._dt.Rows[this._dt.Rows.IndexOf(row)][4] = "A";
			this.pgsLoad.Visible = false;
		}

		private void GetMaterialesOneAula()
		{
			this._hilo = new Thread(new ThreadStart(this.LoadMaterialOfAula));
			this._codAula = Convert.ToInt32(this.cboSalon.SelectedValue);
			this.pgsLoad.Visible = true;
			this.panel1.Enabled = false;

			this._hilo.Start();
		}

		private DataTable TempEstadoMaterial()
		{
			DataTable dtMaterial = new DataTable();

			dtMaterial.Columns.Add("Codigo", typeof(string));
			dtMaterial.Columns.Add("Nombre", typeof(string));

			string[] Codigo = new string[4] { "All" ,"A","B" , "C"};
			string[] Nombre = new string[4] { "Todo","Buen Estado","Req. Reparacion", "Pesimo Estado" };

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

			//DENTRO DEL HLO TENGO QUE PONERLO Y TEGO QUE CONVERTIR TODAS LOS ETDOS QUE SE COMUNICAN CON EL SERVIDOR EN HILOS
			this.cboSalon.ValueMember    = "Codigo";
			this.cboSalon.DisplayMember  = "Description";
			this.cboSalon.DataSource     = this._data.Tables["ListaSalones"];
			this.cboSalon.SelectedIndex  = -1; 
			this.cboSalon.Text           = "Seleccione...";

			this.dgvListado.Enabled = false;
			this.btnSolucionar.Enabled = false;
			this.btnReportar.Enabled = false;
		}

		private void cboSalon_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if(this.dgvListado.Rows.Count > 0)
			{
				this._dt.Rows.Clear();
			}
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
					this.dgvListado.CurrentCell = this.dgvListado.Rows[posicion_row_Mause].Cells[4];

					if(this.dgvListado.CurrentCell.Value.ToString() == "Req. Reparacion")
					{
						this.cmsOptions.Show(this.dgvListado, new Point(e.X, e.Y));
						this.cmsOptions.Items[0].Enabled = true;
						this.cmsOptions.Items[1].Enabled = false;
						this.cmsOptions.Items[2].Enabled = false;
					}
					else 
					{
						if (this.dgvListado.CurrentCell.Value.ToString() == "En Pesimo Estado")
						{
							this.cmsOptions.Show(this.dgvListado, new Point(e.X, e.Y));
							
							this.cmsOptions.Items[0].Enabled = false;
							this.cmsOptions.Items[1].Enabled = true;
							this.cmsOptions.Items[2].Enabled = false;
						}
					}
					if(this.dgvListado.CurrentCell.Value.ToString() == "En Buen Estado")
					{
						this.cmsOptions.Show(this.dgvListado, new Point(e.X, e.Y));
						
						this.cmsOptions.Items[0].Enabled = true;
						this.cmsOptions.Items[1].Enabled = false;
						this.cmsOptions.Items[2].Enabled = false;
					}
				}
			}
		} 

		private void rEPORTARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int    codigoSalon		= Convert.ToInt32(this._codAula);
			int    codigoMaterial	= Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);
			string nombreMaterial   = Convert.ToString(this.dgvListado.CurrentRow.Cells[2].Value);
			string condicion	    = Convert.ToString(this.dgvListado.CurrentRow.Cells[4].Value);

			mdlReporte reporte = new mdlReporte(codigoSalon,codigoMaterial,nombreMaterial,condicion);
			reporte.UpdateCondicionMaterial += new mdlReporte.getCondicionMaterial(this.UpdateCondicionReportIndividual);
			reporte.ShowDialog();
		}

		private void tsmItemSolucionar_Click(object sender, EventArgs e)
		{
			int codigoMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[0].Value);
			string nombreMaterial = Convert.ToString(this.dgvListado.CurrentRow.Cells[2].Value);

			mdlSolucionarMaterial solucionar = new mdlSolucionarMaterial(this._codAula,codigoMaterial,nombreMaterial);
			solucionar.UpdateCondicionMaterial += new mdlSolucionarMaterial.getCondicionMaterial(this.UpdateCondicionSolucionIndividual);
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
					this._dt.DefaultView.RowFilter = ("Descripcion + ' ' + Categoria like '%" + this.txtfiltro.Text + "%' AND C_Value='" + 
					 this.cboTipoBusqueda.SelectedValue.ToString() + "'");
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

		private void cboSalon_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void btnElimnar_Click(object sender, EventArgs e)
		{	
			foreach (DataGridViewRow row in this.dgvListado.Rows)
			{
				DataGridViewCheckBoxCell oCell = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
				oCell.Value = true;
				if((bool)oCell.Value)
				{
					row.Cells["key"].Style.BackColor = Color.Red;
					row.Cells["Descripcion"].Style.BackColor = Color.Red;
					row.Cells["Categoria"].Style.BackColor = Color.Red;
					row.Cells["Condicion"].Style.BackColor = Color.Red;
					row.Cells["Seleccion"].Style.BackColor = Color.Red;
				}
			}
		}

		private void btneliminardd_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = new DataGridViewRow();
			for (int i = 0; i < this.dgvListado.Rows.Count; i ++ )
			{
				row = this.dgvListado.Rows[i];
				if(Convert.ToBoolean(row.Cells[6].Value) == true)
				{
					int id = Convert.ToInt32(row.Cells[0].Value);
					this.dgvListado.Rows.Remove(row);
					i--;
				}
			}
		}

		private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;

			
			if (this.dgvListado.Columns[e.ColumnIndex].Name == "Seleccion")
			{
				DataGridViewRow row = new DataGridViewRow();
				for(int i = 0 ; i < this.dgvListado.Rows.Count; i ++ )
				{
					row = this.dgvListado.Rows[i];
					if(row.Cells[6].Value == null)
						Convert.ToBoolean(row.Cells[6].Value = false);

					if(Convert.ToBoolean(row.Cells[6].Value) == true)
					{
						row.Cells["key"].Style.BackColor = Color.Red;
						row.Cells["Descripcion"].Style.BackColor = Color.Red;
						row.Cells["Categoria"].Style.BackColor = Color.Red;
						row.Cells["Condicion"].Style.BackColor = Color.Red;
						row.Cells["Seleccion"].Style.BackColor = Color.Red;
					}
					else
					{
						row.Cells["key"].Style.BackColor = Color.White;
						row.Cells["Descripcion"].Style.BackColor = Color.White;
						row.Cells["Categoria"].Style.BackColor = Color.White;
						row.Cells["Condicion"].Style.BackColor = Color.White;
						row.Cells["Seleccion"].Style.BackColor = Color.White;
					}
				}
			}
		}

		private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(""+this.dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit));
		}
	}
}
