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
using LawrApp.Layouts.Reportes;
using MaterialControl.ControlMaterial;
using System.Collections;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmReportar : MetroForm
	{
		private Materiales _cMaterial = new Materiales();
		AsignarMaterial _cAsignarMaterial = new AsignarMaterial();
		private DataTable _dt = new DataTable();
		private DataGeneral _data;
		ArrayList codigo = new ArrayList();
		string s = "";
		private Thread _hilo;

		private int _codMaterial,_codSalon;
		private string _codigoMaterialSalon;
		private string _nameMaterial;
		private string _key;
		public frmReportar(DataGeneral dts)
		{
			this._data = dts;
			InitializeComponent();
		}

		#region HILOS

		private void SubmitDelete()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<DataGridViewRow> CantidadRowsChekeadas = (from item in this.dgvListado.Rows.Cast<DataGridViewRow>()
														   let valor = Convert.ToBoolean(item.Cells["Seleccion"].Value) where valor  select item).ToList();

			foreach(DataGridViewRow rows in this.dgvListado.Rows)
			{	 
				if (Convert.ToBoolean(rows.Cells[8].Value) == true)
				{
					this._codigoMaterialSalon = Convert.ToString(rows.Cells[0 ].Value);

					this.panelMain.Enabled = false;

					codigo.Add(_codigoMaterialSalon);
				}

			}
			for (int j = 0; j < codigo.Count; j ++ )
			{
				string[] d = new string[codigo.Count];

				d[j] = Convert.ToString(codigo[j]);

				s += d[j] + ' ';
			}

			if (this._cAsignarMaterial.Delete(s))
			{
				foreach (string d in  codigo)
				{

					DataRow[] datos = this._data.Tables["ListaMaterialesOfAula"].Select("Codigo=" + d + "");

				MessageBox.Show("codigo a eliminar : " + d);
				this.dgvListado.Rows.RemoveAt(this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(datos[0]));

				}

				this.codigo.Clear();
				s = string.Empty.ToString();

				MetroMessageBox.Show(this, "Se han Eliminado: " + CantidadRowsChekeadas.Count + " Materiales correctamene",
									"CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, this._cAsignarMaterial.MsgExeption, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			
			
		    this.pgsLoad.Visible = false;
			this.panelMain.Enabled = true;

			if(this.dgvListado.Rows.Count == 0)
			{
				this.btnSeleccionar.Enabled  = false;
				this.btnDesmarcar.Enabled    = false;
				this.btnimprimir.Enabled     = false;
				this.btnReportar.Enabled     = false;
				this.btnSolucionar.Enabled   = false;
				this.dgvListado.Enabled	     = false;
				this.cboTipoBusqueda.Enabled = false;

				this.txtfiltro.Enabled       = false;

			}
			else
			 this.btneliminar.Enabled = false;

			this._hilo.Abort();
		}
		private void LoadMaterialOfAula()
		{
			CheckForIllegalCrossThreadCalls = false;

			List<lMaterialOfAula> lista = this._cMaterial.ListforAula(this._codSalon);
		
			if (lista != null && lista.Any())
			{
				foreach (lMaterialOfAula item in lista)
				{
					string conditionString = string.Empty;

					switch( item.Condicion )
					{
						case "A": conditionString = "En Buen Estado"; break;
						case "B": conditionString = "Req. Reparacion"; break;
						case "C": conditionString = "En Pesimo Estado"; break;
					}

					object[] obj = new object[9] 
					{
						item.CodigoMaterialSalon,
						this.cboSalon.SelectedValue,
						item.Codigo,
						item.Key,
						item.Description + " " + "_" + item.Marca + " " + "_" + item.Model,
						item.Category,
						conditionString,
						item.Condicion,
						false
					};

					this._data.Tables["ListaMaterialesOfAula"].Rows.Add(obj);
				}
				this.dgvListado.Enabled = true;

				this.dgvListado.DataSource = this._data.Tables["ListaMaterialesOfAula"];

				this.dgvListado.Columns[1].ReadOnly = true;
				this.dgvListado.Columns[2].ReadOnly = true;
				this.dgvListado.Columns[3].ReadOnly = true;
				this.dgvListado.Columns[4].ReadOnly = true;
				this.dgvListado.Columns[5].ReadOnly = true;
				this.dgvListado.Columns[6].ReadOnly = true;
				this.dgvListado.Columns[7].ReadOnly = true;

				this.dgvListado.Columns["Codigo"].Visible               = false;
				this.dgvListado.Columns["CodigoAula"].Visible          = false;
				this.dgvListado.Columns["CodigoMaterial"].Visible      = false;
				this.dgvListado.Columns["Valor"].Visible	            = false;

				this.dgvListado.Columns["Key"].FillWeight				= 60;
				this.dgvListado.Columns["Descripcion"].FillWeight		= 100;
				this.dgvListado.Columns["Categoria"].FillWeight			= 50;
				this.dgvListado.Columns["Condicion"].FillWeight			= 52;
				this.dgvListado.Columns["Seleccion"].FillWeight			= 45;

				this.pgsLoad.Visible    = false;
				this.dgvListado.Enabled = true;

				this.cboTipoBusqueda.ValueMember   = "Codigo";
				this.cboTipoBusqueda.DisplayMember = "Nombre";

				this.cboTipoBusqueda.DataSource = this.TempEstadoMaterial();

				this.cboTipoBusqueda.SelectedValue = "All";
				this.cboTipoBusqueda.Enabled       = true;

				this.dgvListado.ClearSelection();

				this.txtfiltro.Focus();


				foreach (DataGridViewRow row in this.dgvListado.Rows)
				{
					if(row.Cells[6].Value.ToString() == "En Buen Estado")
						this.btnSolucionar.Enabled = false;
				}

				this.txtfiltro.Enabled			   = true;
				this.btnimprimir.Enabled		   = true;
				this.btnSeleccionar.Enabled		   = true;
				this.btneliminar.Enabled		   = false;
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, "No hay Materiales Registrados", "Info!", MessageBoxButtons.OK, 
				MessageBoxIcon.Information);
			}

			this.pgsLoad.Enabled = false;
			this.panelMain.Enabled = true;
			this.btnReportar.Enabled = true;

			this._hilo.Abort();
		}

		#endregion

		#region METODOS

		private void solucionar()
		{
			if (this.dgvListado.CurrentRow.Selected != null)
			{
				this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[2].Value);
				this._key = Convert.ToString(this.dgvListado.CurrentRow.Cells[2].Value);
				this._nameMaterial = Convert.ToString(this.dgvListado.CurrentRow.Cells[4].Value);

				mdlSolucionarMaterial solucionar = new mdlSolucionarMaterial(this._codSalon, _codMaterial, _nameMaterial, _key);
				solucionar.UpdateCondicionMaterial += new mdlSolucionarMaterial.getCondicionMaterial(this.UpdateCondicionSolucionIndividual);
				solucionar.ShowDialog();
			}
			else
				return;
		}

		private void reportar()
		{
			if (this.dgvListado.CurrentRow.Selected)
			{
				this._codMaterial = Convert.ToInt32(this.dgvListado.CurrentRow.Cells[2].Value);
				this._key = Convert.ToString(this.dgvListado.CurrentRow.Cells[3].Value);
				this._nameMaterial = Convert.ToString(this.dgvListado.CurrentRow.Cells[4].Value);
				string condicion = Convert.ToString(this.dgvListado.CurrentRow.Cells[6].Value);

				mdlReporte reporte = new mdlReporte(this._codMaterial, _codSalon, this._nameMaterial, condicion, this._key);
				reporte.UpdateCondicionMaterial += new mdlReporte.getCondicionMaterial(this.UpdateCondicionReportIndividual);
				reporte.ShowDialog();
			}
			else
				return;
		}

		//Actualiza la condicion de un material que se ha reportado individualmente
		private void UpdateCondicionReportIndividual(string condicion)
		{
			int index = this.dgvListado.CurrentCell.RowIndex;
			this._codigoMaterialSalon = this.dgvListado.Rows[index].Cells[0].Value.ToString();
			DataRow[] datos = this._data.Tables["ListaMaterialesOfAula"].Select("Codigo=" + this._codigoMaterialSalon + "");
			DataRow row = datos[0];

			this._data.Tables["ListaMaterialesOfAula"].Rows[this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(row)][6] = condicion;

			switch(condicion)
			{
				case "Req. Reparacion":

					this._data.Tables["ListaMaterialesOfAula"].Rows[this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(row)][7] = "B";

					this.btnReportar.Enabled = true;
					this.btnSolucionar.Enabled = false;

				break;

				case "En Pesimo Estado":

				this._data.Tables["ListaMaterialesOfAula"].Rows[this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(row)][7] = "C";

					this.btnReportar.Enabled = false;
					this.btnSolucionar.Enabled = true;

					break;
			}
		
			this.pgsLoad.Visible = false;
		}

		//Actualiza la condicion de un material que se ha solucionado
		private void UpdateCondicionSolucionIndividual()
		{
			DataRow[] datos = this._data.Tables["ListaMaterialesOfAula"].Select("Codigo=" + this._codigoMaterialSalon);
			
			DataRow row = datos[0];

			this._data.Tables["ListaMaterialesOfAula"].Rows[this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(row)][6] = "En Buen Estado";
			this._data.Tables["ListaMaterialesOfAula"].Rows[this._data.Tables["ListaMaterialesOfAula"].Rows.IndexOf(row)][7] = "A";
			this.pgsLoad.Visible = false;
		}

		private void GetMaterialesOneAula(){
			this._hilo = new Thread(new ThreadStart(this.LoadMaterialOfAula));
			this._codSalon = Convert.ToInt32(this.cboSalon.SelectedValue);
			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		private void EnableBotonesSegunEstados()
		{
			if (this.dgvListado.CurrentCell.ColumnIndex == 6)
			{
				if (this.dgvListado.CurrentRow.Cells[6].Value.ToString() == "En Pesimo Estado")
				{
					this.btnSolucionar.Enabled = true;
					this.btnReportar.Enabled = false;
				}
				if (this.dgvListado.CurrentRow.Cells[6].Value.ToString() == "En Buen Estado")
				{
					this.btnSolucionar.Enabled = false;
					this.btnReportar.Enabled = true;
				}
				if (this.dgvListado.CurrentRow.Cells[6].Value.ToString() == "Req. Reparacion")
				{
					this.btnSolucionar.Enabled = false;
					this.btnReportar.Enabled = true;
				}
			}
			else
				return;
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

		private void ActionForDelete()
		{
			if (this.dgvListado.CurrentRow.Selected)
			{
				this._hilo = new Thread(new ThreadStart(SubmitDelete));

				this.btneliminar.Enabled = false;
				this.pgsLoad.Visible = true;

				this._hilo.Start();
			}
			else
				return;
		}

		#endregion

		private void frmReportar_Load(object sender, EventArgs e)
		{
			//DENTRO DEL HLO TENGO QUE PONERLO Y TEGO QUE CONVERTIR TODAS LOS ETDOS QUE SE COMUNICAN CON EL SERVIDOR EN HILOS

			this.cboSalon.ValueMember    = "Codigo";
			this.cboSalon.DisplayMember  = "Description";
			this.cboSalon.DataSource     = this._data.Tables["ListaSalones"];
			this.cboSalon.SelectedIndex  = -1; 
			this.cboSalon.Text           = "Seleccione...";

			this.dgvListado.Enabled		 = false;
			this.btnSeleccionar.Enabled  = false;
			this.btneliminar.Enabled   = false;
			this.btnReportar.Enabled	 = false;
			this.btnimprimir.Enabled	 = false;
			this.btnSolucionar.Enabled	 = false;
			this.btnReportar.Enabled	 = false;
		}

		private void cboSalon_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if(this.dgvListado.Rows.Count > 0)
			{
				this._data.Tables["ListaMaterialesOfAula"].DefaultView.RowFilter = String.Empty;
				this._data.Tables["ListaMaterialesOfAula"].Rows.Clear();
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
					this.dgvListado.CurrentCell = this.dgvListado.Rows[posicion_row_Mause].Cells[6];

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
			this.reportar();
		}

		private void tsmItemSolucionar_Click(object sender, EventArgs e)
		{
			this.solucionar();
		}

		private void txtfiltro_TextChanged(object sender, EventArgs e)
		{
				if( this.cboTipoBusqueda.SelectedValue.ToString() == "All" )
				{
					this._data.Tables["ListaMaterialesOfAula"].DefaultView.RowFilter = ("Key + ' ' + Descripcion + ' ' + Categoria like '%" + this.txtfiltro.Text + "%'");
					this.dgvListado.DataSource = this._data.Tables["ListaMaterialesOfAula"].DefaultView;
				}
				else
				{
					this.dgvListado.DataSource = this._data.Tables["ListaMaterialesOfAula"].DefaultView;
					this._data.Tables["ListaMaterialesOfAula"].DefaultView.RowFilter = ("Key + ' ' + Descripcion + ' ' + Categoria like '%" + this.txtfiltro.Text + "%' AND C_Value='" + 
					 this.cboTipoBusqueda.SelectedValue.ToString() + "'");	
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
				this._data.Tables["ListaMaterialesOfAula"].DefaultView.RowFilter = ("Valor='" + this.cboTipoBusqueda.SelectedValue.ToString() + "'");
				this.dgvListado.DataSource = this._data.Tables["ListaMaterialesOfAula"].DefaultView;
			}
			else
			{
				this._data.Tables["ListaMaterialesOfAula"].DefaultView.RowFilter = string.Empty;
				this.dgvListado.DataSource = this._data.Tables["ListaMaterialesOfAula"];
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

		private void btneliminardd_Click(object sender, EventArgs e)
		{
			 List<DataGridViewRow> CantidadRowsChekeadas = (from item in this.dgvListado.Rows.Cast<DataGridViewRow>()  
														  let valor = Convert.ToBoolean(item.Cells["Seleccion"].Value) where valor select item).ToList();
			if (CantidadRowsChekeadas.Count() <= 0)
				return;
			this.ActionForDelete();
		}

		private void dgvListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			MessageBox.Show(""+this.dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit));
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in this.dgvListado.Rows)
			{
				DataGridViewCheckBoxCell oCell = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
				oCell.Value = true;
				if ((bool)oCell.Value)
				{
					row.Cells["key"].Style.BackColor         = Color.FromArgb(232, 232, 232);
					row.Cells["Descripcion"].Style.BackColor = Color.FromArgb(232, 232, 232);
					row.Cells["Categoria"].Style.BackColor   = Color.FromArgb(232, 232, 232);
					row.Cells["Condicion"].Style.BackColor   = Color.FromArgb(232, 232, 232);
					row.Cells["Seleccion"].Style.BackColor   = Color.FromArgb(232, 232, 232);

					this.btnDesmarcar.Enabled = true;
				}
			}
		}

		private void btnSolucionar_Click(object sender, EventArgs e)
		{
			this.solucionar();
		}

		private void btnReportar_Click(object sender, EventArgs e)
		{
			this._codigoMaterialSalon = Convert.ToString(this.dgvListado.CurrentRow.Cells[0].Value);

			List<DataGridViewRow> CantidadRowsChekeadas = (from item in this.dgvListado.Rows.Cast<DataGridViewRow>()
														   let valor = Convert.ToBoolean(item.Cells["Seleccion"].Value) where valor  select item).ToList();

			Int32 selectedRowCount = this.dgvListado.Rows.GetRowCount(DataGridViewElementStates.Selected);

			if (CantidadRowsChekeadas.Count() > 1 || selectedRowCount != 1)
				return;
			else
				this.reportar();
		}

		private void btnDesmarcar_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in this.dgvListado.Rows)
			{
				DataGridViewCheckBoxCell oCell = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
				oCell.Value = false;
				if (!(bool)oCell.Value)
				{
					row.Cells["key"].Style.BackColor         = Color.White;
					row.Cells["Descripcion"].Style.BackColor = Color.White;
					row.Cells["Categoria"].Style.BackColor   = Color.White;
					row.Cells["Condicion"].Style.BackColor   = Color.White;
					row.Cells["Seleccion"].Style.BackColor   = Color.White;

					this.btnDesmarcar.Enabled = false;
					this.btneliminar.Enabled = false;
					
				}
			}
		}

		private void dgvListado_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
		{
			if (this.dgvListado.IsCurrentCellDirty)
			{
				this.dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void dgvListado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;

			if (this.dgvListado.Columns[e.ColumnIndex].Name == "Seleccion")
			{
				DataGridViewRow row = new DataGridViewRow();
				for (int i = 0; i < this.dgvListado.Rows.Count; i++)
				{
					row = this.dgvListado.Rows[i];
					if (row.Cells[e.ColumnIndex].Value == null)
						Convert.ToBoolean(row.Cells[e.ColumnIndex].Value = false);

					if ((bool)row.Cells[e.ColumnIndex].Value == true)
					{
						row.Cells["key"].Style.BackColor		 = Color.FromArgb(232, 232, 232);
						row.Cells["Descripcion"].Style.BackColor = Color.FromArgb(232, 232, 232);
						row.Cells["Categoria"].Style.BackColor   = Color.FromArgb(232, 232, 232);
						row.Cells["Condicion"].Style.BackColor   = Color.FromArgb(232, 232, 232);
						row.Cells["Seleccion"].Style.BackColor   = Color.FromArgb(232, 232, 232);

						this.btneliminar.Enabled = true;
					}
					if ((bool)row.Cells[8].Value == false)

						row.Cells["key"].Style.BackColor		 = Color.White;
						row.Cells["Descripcion"].Style.BackColor = Color.White;
						row.Cells["Categoria"].Style.BackColor   = Color.White;
						row.Cells["Condicion"].Style.BackColor   = Color.White;
						row.Cells["Seleccion"].Style.BackColor   = Color.White;

						row.Cells["key"].Style.ForeColor		 = Color.FromArgb(90,92,93);
						row.Cells["Descripcion"].Style.ForeColor = Color.FromArgb(90, 92, 93);
						row.Cells["Categoria"].Style.ForeColor   = Color.FromArgb(90, 92, 93);
						row.Cells["Condicion"].Style.ForeColor   = Color.FromArgb(90, 92, 93);
						row.Cells["Seleccion"].Style.ForeColor   = Color.FromArgb(90, 92, 93);
					}
				}
			}
		
		private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgvListado.Rows.Count > 0)
				this.EnableBotonesSegunEstados();
			else
				MessageBox.Show("No se ha encontrado informacion");
		}
		private void dgvListado_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.A)
			{
				if (this.dgvListado.CurrentCell != null)
				{
					if (this.dgvListado.Rows.Count > 0)
					{
						this.dgvListado.CurrentRow.Selected = true;

						if ((bool)this.dgvListado.CurrentRow.Cells[8].Value == false)
						{
							this.EnableBotonesSegunEstados();
							this.dgvListado.CurrentRow.Cells[8].Value = true;
						}
						else
						{
							this.dgvListado.CurrentRow.Cells[8].Value = false;
							this.dgvListado.CurrentRow.Selected = false;
						}
						  
					}
					else
						return;
				}
				else
					return;
			}
		}

		private void btnimprimir_Click(object sender, EventArgs e)
		{
			rptMaterialesOfAula s = new rptMaterialesOfAula(_data);
			s.Show();
		}

	}
}
