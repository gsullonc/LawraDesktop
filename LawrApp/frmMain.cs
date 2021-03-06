﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using LawrApp.Layouts.Reportes;
using Access;
using Objects.Tables;
using System.Threading;

namespace LawrApp
{
    public partial class frmMain : MetroForm, IFrmMain
    {
        //el formulario login modifica esta variable
        private Login _log = new Login();
        private InitialData _preload = new InitialData();
        private DataGeneral _data;
        private Thread _tr;

        public frmMain( DataGeneral dts )
        {
            _data = dts;
            InitializeComponent();
        }

        #region HILOS

        public void LoadDataDefault()
        {
            Thread.Sleep(200);
            CheckForIllegalCrossThreadCalls = false;

			this.lblLoadInfo.Text = "Cargando: Periodos...";
			this._preload.ListPeriodos( _data );

			this.cboPeriodos.ValueMember = "Codigo";
			this.cboPeriodos.DisplayMember = "Year";
			this.cboPeriodos.DataSource = this._data.Tables["Periodo"];

			this.lblLoadInfo.Text = "Asignando Periodos...";
			this._preload.AsignYear( cboPeriodos.SelectedValue.ToString() );

			this._preload.ListaSalones(this._data);

			if (this._data.Tables["ListaSalones"].Rows.Count > 0)
				this.lblLoadInfo.Text = "Cargando: Salones...";

			this._preload.ListaMateriales(this._data);
			if (this._data.Tables["ListaMaterial"].Rows.Count > 0)
				this.lblLoadInfo.Text = "Cargando: Materiales...";

			if ( this._data.Tables["Departamentos"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Departamentos, Provincias, Distritos...";
				this._preload.ListUbigeo( _data );
			}

			if ( this._data.Tables["TipoDocumento"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Tipos de Documentos...";
				this._preload.ListTipoDocumento( _data );
			}

			if ( this._data.Tables["TipoApoderado"].Rows.Count == 0 )
			{
				this.lblLoadInfo.Text = "Cargando: Tipos de Parientes...";
				this._preload.ListTipoApoderado( _data );
			}

			this.lblLoadInfo.Text = "Cargando: Estudiantes...";
            this._preload.ListaStudents(_data);

			if ( this._data.Tables["Grados"].Rows.Count == 0 )
			this.lblLoadInfo.Text = "Cargando: Grados, Secciones...";
			this._preload.ListaGradoSeccion( _data );

            this.lblLoadInfo.Text = "";
            this.pgsLoadDataDefault.Visible = false;

            this.ControlsEnabled( true );
        }

        #endregion

        #region METODOS

        private void ControlsVisible( bool IsIt )
        {
            this.menuOptions.Visible = IsIt;
            this.panelLogged.Visible = IsIt;
            this.panelLoginIn.Visible = !IsIt;
            this.tableTiles.Visible = IsIt;
            this.panelTitles.Visible = IsIt;
        }

        private void ControlsEnabled( bool IsIt )
        {
            this.menuOptions.Enabled = IsIt;
            this.panelLogged.Enabled = IsIt;
            this.panelLoginIn.Enabled = !IsIt;
            this.tableTiles.Enabled = IsIt;
			this.panelTitles.Visible = IsIt;
        }

		public void ReloadData( bool Reload )
		{
			if ( Reload )
			{
				this._tr = new Thread( new ThreadStart( this.LoadDataDefault ) );

				this.ControlsVisible( true );
				this.ControlsEnabled( false );
				this.btnLogin.Enabled = false;

				this.pgsLoadDataDefault.Visible = true;

				this._tr.Start();
			}
		}

        #endregion

        #region EVENTOS

        private void frmMain_Load( object sender, EventArgs e )
        {
            if ( this._log.TokenIsRegistered() )
            {
                this._tr = new Thread( new ThreadStart( this.LoadDataDefault ) );

                this.lblUserName.Text = this._log.UserFullName;
                this.lblUserType.Text = this._log.UserType;
                this.pbUserPicture.ImageLocation = this._log.LocationImage;

				this.ControlsVisible( true );
				this.ControlsEnabled( false );
				this.btnLogin.Enabled = false;

				this.pgsLoadDataDefault.Visible = true;

                this._tr.Start();
            }
            else
            {
				this.ControlsVisible( false );
				this.ControlsEnabled( false );
				this.btnLogin.Enabled = true;
				this.pgsLoadDataDefault.Visible = false;
            }
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            frmLogIn frmlog = new frmLogIn( _data );
            frmlog.classLog = this._log;
            frmlog.Show();
            this.Close();
		}

		private void btnRegistrarAlumno_Click( object sender, EventArgs e )
		{
			Layouts.prsMatricula.frmInitialMessage alumno = new Layouts.prsMatricula.frmInitialMessage( this._data );
			alumno.Show();
			this.Close();
		}

		private void btnLogOut_Click( object sender, EventArgs e )
		{
			DialogResult result = MetroMessageBox.Show( this,
				"\nDeseas Realmente Cerrar Sesión? \n\n Pulsa OK para cerrar sesión...",
				"Advertencia",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Exclamation );

			if ( result == DialogResult.Cancel ) return;

			if ( _log.SendLogOut() ) ControlsVisible( false );

			this.btnLogin.Enabled = true;
			this.panelLoginIn.Enabled = true;

		}

		private void btnNewAcademyYear_Click( object sender, EventArgs e )
		{
			Layouts.prsApertura.frmInitialMessage frminitprs = new Layouts.prsApertura.frmInitialMessage( this._data );
			frminitprs.Show();
			this.Close();
		}

		private void cambiarServidorToolStripMenuItem_Click( object sender, EventArgs e )
		{
			LawrApp.frmConfigServer server = new frmConfigServer();
			server.Owner = this;
			server.ShowDialog( this );
		}

        #endregion

		private void datosDeAlumnoToolStripMenuItem_Click( object sender, EventArgs e )
		{
			//Reportes.Forms.frmAlumnoMatricula mat = new Reportes.Forms.frmAlumnoMatricula();
			//mat.Show();
		}

		private void modificarDatosDeAlumnosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_FindAlumno falumno = new Layouts.regAlumno.frm_FindAlumno( this._data );
			falumno.Show();
			this.Close();
		}

		private void documentosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Documents documents = new Layouts.regAlumno.frm_Documents( this._data );
			documents.Show();
			this.Close();
		}

		private void apoderadosToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Layouts.regAlumno.frm_Parents documents = new Layouts.regAlumno.frm_Parents( this._data );
			documents.Show();
			this.Close();
		}

		private void btnFichasStudents_Click( object sender, EventArgs e )
		{
			Layouts.Fichas.Students.frmSearchStudents search = new Layouts.Fichas.Students.frmSearchStudents( this._data );
			search.Show();
			this.Close();
		}

		private void registroDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmRegistrarMaterial material = new Layouts.MaterialControl.frmRegistrarMaterial(this._data);
			material.Show();
			this.Close();
		}

		private void reportarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmReportar ReportarMaterial = new Layouts.MaterialControl.frmReportar(this._data);
			ReportarMaterial.Show();
			this.Close();
		}

		private void registroDeInformeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmInformeInventario RegInformeInventario = new Layouts.MaterialControl.frmInformeInventario(this._data);
			RegInformeInventario.Show();
			this.Close();
		}

		private void regisroDeIngresosDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmIngresos Ingresos = new Layouts.MaterialControl.frmIngresos(this._data);
			Ingresos.Show();
			this.Close();
		}

		private void listadoDeIngresoPorMaterialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmInformeIngresosPorMaterial Listado = new Layouts.MaterialControl.frmInformeIngresosPorMaterial(this._data);
			Listado.Show();
			this.Close();
		}

		private void listadoMaterialPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Layouts.MaterialControl.frmAsignarMaterial Asignar = new Layouts.MaterialControl.frmAsignarMaterial(this._data);
			Asignar.Show();
			this.Close();
		}

		private void especificoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//rptEspecifico rptEspecifico = new rptEspecifico(_data);
			//rptEspecifico.Show();
		}
	}
}
