﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using Registers.Students;
using Objects.Processes;

namespace LawrApp.Layouts.prsMatricula
{
	public partial class frmAsignaClase : MetroForm
	{
		private DataGeneral _data;
		private Alumnos alum = new Alumnos();
		private bool _isNewStudent = false;
		private bool _closeInProcesses = false;
		private int _codigoAlumno;

		#region PROPIEDADES

		public bool IsNewStudent
		{
			get { return this._isNewStudent; }
			set { this._isNewStudent = value; }
		}

		public int CodigoAlumno
		{
			get { return this._codigoAlumno; }
			set { this._codigoAlumno = value; }
		}

		public frmAsignaClase( DataGeneral dts )
		{
			this._data = dts;
			InitializeComponent();
		}

		#endregion

		#region METODOS
			
		public void sendDataKeys()
		{
			int indice = this.dgClases.CurrentRow.Index;
			frmAlumno alumno = new frmAlumno( this._data );
			alumno.IsNewStudent = this._isNewStudent;
			alumno.IdClase = Convert.ToInt32( this.dgClases.Rows[indice].Cells[0].Value );
			alumno.IdNivel = Convert.ToInt32( this.cboniveles.SelectedValue );

			this._closeInProcesses = true;

			alumno.Show();
			this.Close();
		}

		#endregion

		private void btnPreview_Click( object sender, EventArgs e )
		{
			frmInitialMessage msg = new frmInitialMessage( this._data );
			msg.IsNewStudent = _isNewStudent;
			this._closeInProcesses = true;
			msg.Show();
			this.Close();
		}

		private void frmAsignaClase_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( ! this._closeInProcesses )
			{
				frmMain main = new frmMain( this._data );
				main.Show();
			}
		}

		private void frmAsignaClase_Load( object sender, EventArgs e )
		{
			this.cboniveles.DisplayMember = "Name";
			this.cboniveles.ValueMember = "Codigo";
			this.cboniveles.DataSource = this._data.Tables["Niveles"];
			this.cboniveles.SelectedIndex = -1;
			this.cboniveles.Text = "Seleccione...";

			this.cboseccion.DisplayMember = "Name";
			this.cboseccion.ValueMember = "Codigo";
			this.cboseccion.DataSource = this._data.Tables["Secciones"];
			this.cboseccion.SelectedIndex = -1;
			this.cboseccion.Text = "Seleccione...";

			if( this._isNewStudent )
				this.txtname.Text = "Nuevo Alumno";

			this.cboniveles.Select();
		}

		private void cboniveles_SelectionChangeCommitted( object sender, EventArgs e )
		{
			ComboBox cbo = ( (ComboBox) sender );
			this.cbogrado.DisplayMember = "Name";
			this.cbogrado.ValueMember = "Codigo";

			this.cbogrado.DataSource = this._data.Tables["Grados"].Select( "CodigoNivel=" + cbo.SelectedValue );
			this.cbogrado.SelectedIndex = -1;
			this.cbogrado.Text = "Seleccione...";
		}

		private void btnsearch_Click( object sender, EventArgs e )
		{
			List<FillClases> lista = this.alum.FindClases( Convert.ToInt32(this.cbogrado.SelectedValue), Convert.ToInt32(this.cboseccion.SelectedValue) );

			this.dgClases.Rows.Clear();

			if ( lista != null && lista.Any() )
			{
				foreach ( FillClases item in lista )
				{
					var temp = new object[] 
					{ 
						item.Codigo,
						item.Grado,
						item.Seccion,
						item.Nivel,
						item.Turno
					};

					this.dgClases.Rows.Add( temp );
				}

				this.dgClases.CurrentCell = this.dgClases.Rows[0].Cells[1];
			}
		}

		private void dgClases_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			this.sendDataKeys();
		}

		private void dgClases_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyData == Keys.Enter )
			{
				e.SuppressKeyPress = true;
				this.sendDataKeys();
			}
		}
	}
}
