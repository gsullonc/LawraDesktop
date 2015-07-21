﻿namespace LawrApp.Layouts.regAlumno
{
	partial class frm_Parents
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.toltipValidParent = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain = new System.Windows.Forms.Panel();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.tabPageListado = new MetroFramework.Controls.MetroTabPage();
			this.panelListado = new System.Windows.Forms.Panel();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnNuevo = new MetroFramework.Controls.MetroButton();
			this.tabPageRegistro = new MetroFramework.Controls.MetroTabPage();
			this.panelRegistros = new System.Windows.Forms.Panel();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.txtAddress = new MetroFramework.Controls.MetroTextBox();
			this.TxtLasName = new MetroFramework.Controls.MetroTextBox();
			this.lbValidacionTipoDocumento = new System.Windows.Forms.Label();
			this.lbValidactionParentesco = new System.Windows.Forms.Label();
			this.lbValidationfechaNacimiento = new System.Windows.Forms.Label();
			this.lbValidacionsexo = new System.Windows.Forms.Label();
			this.lbvalidacionNumerDocumet = new System.Windows.Forms.Label();
			this.lbvalidacionApellidos = new System.Windows.Forms.Label();
			this.lbvalidacionname = new System.Windows.Forms.Label();
			this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
			this.cboparentesco = new System.Windows.Forms.ComboBox();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
			this.txtPhones = new MetroFramework.Controls.MetroTextBox();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.txtDocumentNumber = new MetroFramework.Controls.MetroTextBox();
			this.cboTypeDocument = new System.Windows.Forms.ComboBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.cboSexo = new System.Windows.Forms.ComboBox();
			this.txtNames = new MetroFramework.Controls.MetroTextBox();
			this.btnSearchStudent = new MetroFramework.Controls.MetroButton();
			this.txtNameStudent = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoading = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageListado.SuspendLayout();
			this.panelListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.tabPageRegistro.SuspendLayout();
			this.panelRegistros.SuspendLayout();
			this.gbDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// toltipValidParent
			// 
			this.toltipValidParent.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValidParent.ToolTipTitle = "Requerido";
			// 
			// panelMain
			// 
			this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panelMain.Controls.Add(this.pgsLoading);
			this.panelMain.Controls.Add(this.tabControl);
			this.panelMain.Controls.Add(this.btnSearchStudent);
			this.panelMain.Controls.Add(this.txtNameStudent);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 471);
			this.panelMain.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageListado);
			this.tabControl.Controls.Add(this.tabPageRegistro);
			this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.tabControl.HotTrack = true;
			this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
			this.tabControl.Location = new System.Drawing.Point(3, 39);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 1;
			this.tabControl.Size = new System.Drawing.Size(734, 417);
			this.tabControl.Style = MetroFramework.MetroColorStyle.Green;
			this.tabControl.TabIndex = 3;
			this.tabControl.UseSelectable = true;
			// 
			// tabPageListado
			// 
			this.tabPageListado.Controls.Add(this.panelListado);
			this.tabPageListado.HorizontalScrollbarBarColor = true;
			this.tabPageListado.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageListado.HorizontalScrollbarSize = 4;
			this.tabPageListado.Location = new System.Drawing.Point(4, 44);
			this.tabPageListado.Name = "tabPageListado";
			this.tabPageListado.Size = new System.Drawing.Size(726, 369);
			this.tabPageListado.TabIndex = 0;
			this.tabPageListado.Text = "Apoderados";
			this.tabPageListado.VerticalScrollbarBarColor = true;
			this.tabPageListado.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageListado.VerticalScrollbarSize = 5;
			// 
			// panelListado
			// 
			this.panelListado.BackColor = System.Drawing.Color.Transparent;
			this.panelListado.Controls.Add(this.dgvListado);
			this.panelListado.Controls.Add(this.btnSalir);
			this.panelListado.Controls.Add(this.btnEliminar);
			this.panelListado.Controls.Add(this.btnModificar);
			this.panelListado.Controls.Add(this.btnNuevo);
			this.panelListado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelListado.Enabled = false;
			this.panelListado.Location = new System.Drawing.Point(0, 0);
			this.panelListado.Name = "panelListado";
			this.panelListado.Size = new System.Drawing.Size(726, 369);
			this.panelListado.TabIndex = 2;
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colParentesco,
            this.colModifiedDate});
			this.dgvListado.Location = new System.Drawing.Point(3, 3);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.Height = 28;
			this.dgvListado.RowTemplate.ReadOnly = true;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(720, 324);
			this.dgvListado.TabIndex = 8;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colNombre
			// 
			this.colNombre.HeaderText = "Nombre";
			this.colNombre.Name = "colNombre";
			this.colNombre.ReadOnly = true;
			// 
			// colParentesco
			// 
			this.colParentesco.FillWeight = 70F;
			this.colParentesco.HeaderText = "Parentesco";
			this.colParentesco.Name = "colParentesco";
			this.colParentesco.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.FillWeight = 60F;
			this.colModifiedDate.HeaderText = "Ultima Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 333);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(68, 33);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(486, 333);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(68, 33);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(560, 333);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(68, 33);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(655, 333);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(68, 33);
			this.btnNuevo.TabIndex = 4;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseSelectable = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// tabPageRegistro
			// 
			this.tabPageRegistro.Controls.Add(this.panelRegistros);
			this.tabPageRegistro.HorizontalScrollbarBarColor = true;
			this.tabPageRegistro.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.HorizontalScrollbarSize = 4;
			this.tabPageRegistro.Location = new System.Drawing.Point(4, 44);
			this.tabPageRegistro.Name = "tabPageRegistro";
			this.tabPageRegistro.Size = new System.Drawing.Size(726, 369);
			this.tabPageRegistro.TabIndex = 1;
			this.tabPageRegistro.Text = "Registros";
			this.tabPageRegistro.VerticalScrollbarBarColor = true;
			this.tabPageRegistro.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageRegistro.VerticalScrollbarSize = 5;
			// 
			// panelRegistros
			// 
			this.panelRegistros.BackColor = System.Drawing.Color.Transparent;
			this.panelRegistros.Controls.Add(this.btnCancelar);
			this.panelRegistros.Controls.Add(this.btnGuardar);
			this.panelRegistros.Controls.Add(this.gbDatos);
			this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRegistros.Enabled = false;
			this.panelRegistros.Location = new System.Drawing.Point(0, 0);
			this.panelRegistros.Name = "panelRegistros";
			this.panelRegistros.Size = new System.Drawing.Size(726, 369);
			this.panelRegistros.TabIndex = 2;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(567, 333);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 33);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(648, 333);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 33);
			this.btnGuardar.TabIndex = 1;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.txtAddress);
			this.gbDatos.Controls.Add(this.TxtLasName);
			this.gbDatos.Controls.Add(this.lbValidacionTipoDocumento);
			this.gbDatos.Controls.Add(this.lbValidactionParentesco);
			this.gbDatos.Controls.Add(this.lbValidationfechaNacimiento);
			this.gbDatos.Controls.Add(this.lbValidacionsexo);
			this.gbDatos.Controls.Add(this.lbvalidacionNumerDocumet);
			this.gbDatos.Controls.Add(this.lbvalidacionApellidos);
			this.gbDatos.Controls.Add(this.lbvalidacionname);
			this.gbDatos.Controls.Add(this.metroLabel10);
			this.gbDatos.Controls.Add(this.cboparentesco);
			this.gbDatos.Controls.Add(this.metroLabel9);
			this.gbDatos.Controls.Add(this.metroLabel8);
			this.gbDatos.Controls.Add(this.metroLabel7);
			this.gbDatos.Controls.Add(this.metroLabel6);
			this.gbDatos.Controls.Add(this.metroLabel5);
			this.gbDatos.Controls.Add(this.metroLabel4);
			this.gbDatos.Controls.Add(this.metroLabel3);
			this.gbDatos.Controls.Add(this.metroLabel2);
			this.gbDatos.Controls.Add(this.metroLabel11);
			this.gbDatos.Controls.Add(this.txtPhones);
			this.gbDatos.Controls.Add(this.txtEmail);
			this.gbDatos.Controls.Add(this.txtDocumentNumber);
			this.gbDatos.Controls.Add(this.cboTypeDocument);
			this.gbDatos.Controls.Add(this.dtpBirthday);
			this.gbDatos.Controls.Add(this.cboSexo);
			this.gbDatos.Controls.Add(this.txtNames);
			this.gbDatos.Location = new System.Drawing.Point(3, 3);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Size = new System.Drawing.Size(720, 324);
			this.gbDatos.TabIndex = 0;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "Datos del Apoderado";
			// 
			// txtAddress
			// 
			this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtAddress.Lines = new string[0];
			this.txtAddress.Location = new System.Drawing.Point(298, 273);
			this.txtAddress.MaxLength = 32767;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.PasswordChar = '\0';
			this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtAddress.SelectedText = "";
			this.txtAddress.Size = new System.Drawing.Size(416, 29);
			this.txtAddress.TabIndex = 61;
			this.txtAddress.UseSelectable = true;
			// 
			// TxtLasName
			// 
			this.TxtLasName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtLasName.Lines = new string[0];
			this.TxtLasName.Location = new System.Drawing.Point(331, 57);
			this.TxtLasName.MaxLength = 32767;
			this.TxtLasName.Name = "TxtLasName";
			this.TxtLasName.PasswordChar = '\0';
			this.TxtLasName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtLasName.SelectedText = "";
			this.TxtLasName.Size = new System.Drawing.Size(383, 29);
			this.TxtLasName.TabIndex = 36;
			this.TxtLasName.UseSelectable = true;
			// 
			// lbValidacionTipoDocumento
			// 
			this.lbValidacionTipoDocumento.BackColor = System.Drawing.Color.Transparent;
			this.lbValidacionTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValidacionTipoDocumento.ForeColor = System.Drawing.Color.Red;
			this.lbValidacionTipoDocumento.Location = new System.Drawing.Point(132, 183);
			this.lbValidacionTipoDocumento.Name = "lbValidacionTipoDocumento";
			this.lbValidacionTipoDocumento.Size = new System.Drawing.Size(13, 16);
			this.lbValidacionTipoDocumento.TabIndex = 60;
			this.lbValidacionTipoDocumento.Text = "*";
			// 
			// lbValidactionParentesco
			// 
			this.lbValidactionParentesco.BackColor = System.Drawing.Color.Transparent;
			this.lbValidactionParentesco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValidactionParentesco.ForeColor = System.Drawing.Color.Red;
			this.lbValidactionParentesco.Location = new System.Drawing.Point(514, 108);
			this.lbValidactionParentesco.Name = "lbValidactionParentesco";
			this.lbValidactionParentesco.Size = new System.Drawing.Size(13, 16);
			this.lbValidactionParentesco.TabIndex = 59;
			this.lbValidactionParentesco.Text = "*";
			// 
			// lbValidationfechaNacimiento
			// 
			this.lbValidationfechaNacimiento.BackColor = System.Drawing.Color.Transparent;
			this.lbValidationfechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValidationfechaNacimiento.ForeColor = System.Drawing.Color.Red;
			this.lbValidationfechaNacimiento.Location = new System.Drawing.Point(280, 108);
			this.lbValidationfechaNacimiento.Name = "lbValidationfechaNacimiento";
			this.lbValidationfechaNacimiento.Size = new System.Drawing.Size(13, 16);
			this.lbValidationfechaNacimiento.TabIndex = 58;
			this.lbValidationfechaNacimiento.Text = "*";
			// 
			// lbValidacionsexo
			// 
			this.lbValidacionsexo.BackColor = System.Drawing.Color.Transparent;
			this.lbValidacionsexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValidacionsexo.ForeColor = System.Drawing.Color.Red;
			this.lbValidacionsexo.Location = new System.Drawing.Point(43, 106);
			this.lbValidacionsexo.Name = "lbValidacionsexo";
			this.lbValidacionsexo.Size = new System.Drawing.Size(51, 16);
			this.lbValidacionsexo.TabIndex = 57;
			this.lbValidacionsexo.Text = "*";
			// 
			// lbvalidacionNumerDocumet
			// 
			this.lbvalidacionNumerDocumet.BackColor = System.Drawing.Color.Transparent;
			this.lbvalidacionNumerDocumet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbvalidacionNumerDocumet.ForeColor = System.Drawing.Color.Red;
			this.lbvalidacionNumerDocumet.Location = new System.Drawing.Point(281, 183);
			this.lbvalidacionNumerDocumet.Name = "lbvalidacionNumerDocumet";
			this.lbvalidacionNumerDocumet.Size = new System.Drawing.Size(13, 16);
			this.lbvalidacionNumerDocumet.TabIndex = 56;
			this.lbvalidacionNumerDocumet.Text = "*";
			// 
			// lbvalidacionApellidos
			// 
			this.lbvalidacionApellidos.BackColor = System.Drawing.Color.Transparent;
			this.lbvalidacionApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbvalidacionApellidos.ForeColor = System.Drawing.Color.Red;
			this.lbvalidacionApellidos.Location = new System.Drawing.Point(390, 36);
			this.lbvalidacionApellidos.Name = "lbvalidacionApellidos";
			this.lbvalidacionApellidos.Size = new System.Drawing.Size(13, 16);
			this.lbvalidacionApellidos.TabIndex = 55;
			this.lbvalidacionApellidos.Text = "*";
			// 
			// lbvalidacionname
			// 
			this.lbvalidacionname.BackColor = System.Drawing.Color.Transparent;
			this.lbvalidacionname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbvalidacionname.ForeColor = System.Drawing.Color.Red;
			this.lbvalidacionname.Location = new System.Drawing.Point(65, 38);
			this.lbvalidacionname.Name = "lbvalidacionname";
			this.lbvalidacionname.Size = new System.Drawing.Size(24, 16);
			this.lbvalidacionname.TabIndex = 54;
			this.lbvalidacionname.Text = "*";
			// 
			// metroLabel10
			// 
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new System.Drawing.Point(442, 105);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new System.Drawing.Size(75, 19);
			this.metroLabel10.TabIndex = 53;
			this.metroLabel10.Text = "Parentesco:";
			// 
			// cboparentesco
			// 
			this.cboparentesco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboparentesco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboparentesco.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cboparentesco.Location = new System.Drawing.Point(442, 127);
			this.cboparentesco.Name = "cboparentesco";
			this.cboparentesco.Size = new System.Drawing.Size(273, 29);
			this.cboparentesco.TabIndex = 39;
			this.cboparentesco.Text = "Seleccione...";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(298, 251);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(66, 19);
			this.metroLabel9.TabIndex = 52;
			this.metroLabel9.Text = "Dirección:";
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(6, 251);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(44, 19);
			this.metroLabel8.TabIndex = 51;
			this.metroLabel8.Text = "Email:";
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(442, 180);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(74, 19);
			this.metroLabel7.TabIndex = 50;
			this.metroLabel7.Text = "Telefono(s):";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(190, 180);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(88, 19);
			this.metroLabel6.TabIndex = 49;
			this.metroLabel6.Text = "Numero Doc.";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(6, 180);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(129, 19);
			this.metroLabel5.TabIndex = 48;
			this.metroLabel5.Text = "Tipo de Documento:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(190, 105);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(88, 19);
			this.metroLabel4.TabIndex = 47;
			this.metroLabel4.Text = "F. Nacimiento";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(7, 105);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(40, 19);
			this.metroLabel3.TabIndex = 46;
			this.metroLabel3.Text = "Sexo:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(329, 35);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(66, 19);
			this.metroLabel2.TabIndex = 45;
			this.metroLabel2.Text = "Apellidos:";
			// 
			// metroLabel11
			// 
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new System.Drawing.Point(6, 35);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new System.Drawing.Size(67, 19);
			this.metroLabel11.TabIndex = 44;
			this.metroLabel11.Text = "Nombres:";
			// 
			// txtPhones
			// 
			this.txtPhones.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtPhones.Lines = new string[0];
			this.txtPhones.Location = new System.Drawing.Point(442, 202);
			this.txtPhones.MaxLength = 32767;
			this.txtPhones.Name = "txtPhones";
			this.txtPhones.PasswordChar = '\0';
			this.txtPhones.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPhones.SelectedText = "";
			this.txtPhones.Size = new System.Drawing.Size(272, 29);
			this.txtPhones.TabIndex = 42;
			this.txtPhones.UseSelectable = true;
			// 
			// txtEmail
			// 
			this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtEmail.Lines = new string[0];
			this.txtEmail.Location = new System.Drawing.Point(6, 273);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(286, 29);
			this.txtEmail.TabIndex = 43;
			this.txtEmail.UseSelectable = true;
			// 
			// txtDocumentNumber
			// 
			this.txtDocumentNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtDocumentNumber.Lines = new string[0];
			this.txtDocumentNumber.Location = new System.Drawing.Point(190, 202);
			this.txtDocumentNumber.MaxLength = 32767;
			this.txtDocumentNumber.Name = "txtDocumentNumber";
			this.txtDocumentNumber.PasswordChar = '\0';
			this.txtDocumentNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDocumentNumber.SelectedText = "";
			this.txtDocumentNumber.Size = new System.Drawing.Size(246, 29);
			this.txtDocumentNumber.TabIndex = 41;
			this.txtDocumentNumber.UseSelectable = true;
			this.txtDocumentNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumentNumber_KeyDown);
			// 
			// cboTypeDocument
			// 
			this.cboTypeDocument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboTypeDocument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboTypeDocument.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cboTypeDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTypeDocument.FormattingEnabled = true;
			this.cboTypeDocument.Location = new System.Drawing.Point(6, 202);
			this.cboTypeDocument.Name = "cboTypeDocument";
			this.cboTypeDocument.Size = new System.Drawing.Size(178, 29);
			this.cboTypeDocument.TabIndex = 40;
			this.cboTypeDocument.SelectionChangeCommitted += new System.EventHandler(this.cboTypeDocument_SelectionChangeCommitted);
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
			this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthday.Location = new System.Drawing.Point(190, 127);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(246, 29);
			this.dtpBirthday.TabIndex = 38;
			this.dtpBirthday.Value = new System.DateTime(2015, 5, 24, 20, 26, 10, 0);
			// 
			// cboSexo
			// 
			this.cboSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cboSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSexo.FormattingEnabled = true;
			this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
			this.cboSexo.Location = new System.Drawing.Point(7, 127);
			this.cboSexo.Name = "cboSexo";
			this.cboSexo.Size = new System.Drawing.Size(177, 29);
			this.cboSexo.TabIndex = 37;
			this.cboSexo.Text = "Seleccione...";
			this.cboSexo.SelectionChangeCommitted += new System.EventHandler(this.cboSexo_SelectionChangeCommitted);
			// 
			// txtNames
			// 
			this.txtNames.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNames.Lines = new string[0];
			this.txtNames.Location = new System.Drawing.Point(6, 57);
			this.txtNames.MaxLength = 32767;
			this.txtNames.Name = "txtNames";
			this.txtNames.PasswordChar = '\0';
			this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNames.SelectedText = "";
			this.txtNames.Size = new System.Drawing.Size(319, 29);
			this.txtNames.TabIndex = 35;
			this.txtNames.UseSelectable = true;
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.Location = new System.Drawing.Point(662, 3);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(75, 30);
			this.btnSearchStudent.TabIndex = 2;
			this.btnSearchStudent.Text = "Buscar";
			this.btnSearchStudent.UseSelectable = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// txtNameStudent
			// 
			this.txtNameStudent.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNameStudent.Lines = new string[0];
			this.txtNameStudent.Location = new System.Drawing.Point(67, 3);
			this.txtNameStudent.MaxLength = 32767;
			this.txtNameStudent.Name = "txtNameStudent";
			this.txtNameStudent.PasswordChar = '\0';
			this.txtNameStudent.ReadOnly = true;
			this.txtNameStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNameStudent.SelectedText = "";
			this.txtNameStudent.Size = new System.Drawing.Size(589, 30);
			this.txtNameStudent.TabIndex = 1;
			this.txtNameStudent.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 9);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(58, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Alumno:";
			// 
			// pgsLoading
			// 
			this.pgsLoading.Location = new System.Drawing.Point(3, 452);
			this.pgsLoading.Maximum = 100;
			this.pgsLoading.Name = "pgsLoading";
			this.pgsLoading.Size = new System.Drawing.Size(16, 16);
			this.pgsLoading.Speed = 2F;
			this.pgsLoading.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoading.TabIndex = 9;
			this.pgsLoading.UseSelectable = true;
			this.pgsLoading.Value = 50;
			this.pgsLoading.Visible = false;
			// 
			// frm_Parents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Parents";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Registro Parientes";
			this.Load += new System.EventHandler(this.frm_Parents_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageListado.ResumeLayout(false);
			this.panelListado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.tabPageRegistro.ResumeLayout(false);
			this.panelRegistros.ResumeLayout(false);
			this.gbDatos.ResumeLayout(false);
			this.gbDatos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toltipValidParent;
		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroTabControl tabControl;
		private MetroFramework.Controls.MetroTabPage tabPageListado;
		private System.Windows.Forms.Panel panelListado;
		private MetroFramework.Controls.MetroTabPage tabPageRegistro;
		private System.Windows.Forms.Panel panelRegistros;
		private MetroFramework.Controls.MetroButton btnSearchStudent;
		private MetroFramework.Controls.MetroTextBox txtNameStudent;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnNuevo;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn colParentesco;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private System.Windows.Forms.GroupBox gbDatos;
		public MetroFramework.Controls.MetroTextBox TxtLasName;
		private System.Windows.Forms.Label lbValidacionTipoDocumento;
		private System.Windows.Forms.Label lbValidactionParentesco;
		private System.Windows.Forms.Label lbValidationfechaNacimiento;
		private System.Windows.Forms.Label lbValidacionsexo;
		private System.Windows.Forms.Label lbvalidacionNumerDocumet;
		private System.Windows.Forms.Label lbvalidacionApellidos;
		private System.Windows.Forms.Label lbvalidacionname;
		private MetroFramework.Controls.MetroLabel metroLabel10;
		private System.Windows.Forms.ComboBox cboparentesco;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel11;
		public MetroFramework.Controls.MetroTextBox txtPhones;
		public MetroFramework.Controls.MetroTextBox txtEmail;
		private MetroFramework.Controls.MetroTextBox txtDocumentNumber;
		private System.Windows.Forms.ComboBox cboTypeDocument;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.ComboBox cboSexo;
		public MetroFramework.Controls.MetroTextBox txtNames;
		public MetroFramework.Controls.MetroTextBox txtAddress;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoading;
	}
}