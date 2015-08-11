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
using MetroFramework;

using MaterialControl.ControlMaterial;
using Objects.Processes;
using System.Collections;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmInformeInventario : MetroForm
	{
		DataGeneral _data = new DataGeneral();
		DataTable _dt = new DataTable();

		private Thread _hilo;
		private int _codAula;

		private Materiales _cMaterial = new Materiales();
		

		public frmInformeInventario(DataGeneral dts)
		{
			InitializeComponent();
		}

		#region HILO

		private void LoadMaterialOfAula()
		{
			CheckForIllegalCrossThreadCalls = false;
	   
			List<lMaterial> lista = this._cMaterial.ListforAula(this._codAula);

			if (lista != null && lista.Any())
			{
				foreach (lMaterial item in lista)

				{
					string conditionString = string.Empty;
					//switch (item.Condicion)
					//{
					//	case "A": conditionString = "En Buen Estado"; break;
					//	case "B": conditionString = "Req. Reparacion"; break;
					//	case "C": conditionString = "En Pesimo Estado"; break;
					//}
				
					object[] obj = new object[5] 
					{
						item.Codigo,
						item.Key,
						item.Description + " " + "_" + item.Marca + " " + "_" + item.Model,
						item.Category,
						item.Condicion
					};

					 this._dt.Rows.Add(obj);
					 this.dgvListado.Rows.Add(obj);

					 this.colCondicion.DataSource = this.Condition_Table();
					 this.colCondicion.ValueMember = "Codigo";
					 this.colCondicion.DisplayMember = "Descripcion";
					
				}
				
				this.pgsLoad.Visible = false;
				this.dgvListado.Enabled = true;
			}
			else
			{
				this.pgsLoad.Visible = false;
				MetroMessageBox.Show(this, "No hay Materiales Registrados", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			this.pgsLoad.Enabled = false;
			this.panelMain.Enabled = true;
		
			this.btnGuardar.Enabled = true;
			this.btnSalir.Enabled = true;

			 this._hilo.Abort();
		}

		private void DataAulas()
		{
			CheckForIllegalCrossThreadCalls = false;

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

			this.cboSalon.ValueMember   = "Codigo";
			this.cboSalon.DisplayMember = "Description";

			this.cboSalon.DataSource    = this._data.Tables["ListaSalones"];

			this.cboSalon.SelectedIndex = -1;
			this.cboSalon.Text          = "Seleccione...";
		}


		#endregion

		#region METODOS

		private void AgregarColumnDatatableGlobal()
		{
			this._dt.Columns.Add("Codigo",      typeof(int));
			this._dt.Columns.Add("Keys",	    typeof(string));
			this._dt.Columns.Add("Descripcion", typeof(string));
			this._dt.Columns.Add("Categoria",   typeof(string));
			this._dt.Columns.Add("Condicion",   typeof(string));
		}

		#endregion

		private void cboSalon_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
				e.SuppressKeyPress = true;
		}

		private void cboSalon_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this._hilo = new Thread(new ThreadStart(this.LoadMaterialOfAula));
			this._codAula = Convert.ToInt32(this.cboSalon.SelectedValue);
			this.dgvListado.Rows.Clear();
			this.pgsLoad.Visible = true;
			this.panelMain.Enabled = false;

			this._hilo.Start();
		}

		private DataTable Condition_Table()
		{
			DataTable _dt = new DataTable();
			_dt.Columns.Add("Codigo", typeof(string));
			_dt.Columns.Add("Descripcion", typeof(string));

			object[] estados = new object[3] { "Buen estado", "Reg.Reparacion", "En Mal estado" };
			string[] letras  = new string[3] { "A", "B", "C" };
			
			for(int i=0; i < estados.Length; i ++ )
			{
				object[] d = new object[]
				{
					letras[i],
					estados[i]
				};

				_dt.Rows.Add(d);

				}

			return _dt;
		}

		private void frmInformeInventario_Load(object sender, EventArgs e)
		{
			this.AgregarColumnDatatableGlobal();

			this._hilo = new Thread(new ThreadStart(this.DataAulas));

			this._hilo.Start();

		}
	}
}
