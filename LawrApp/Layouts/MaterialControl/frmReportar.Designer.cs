﻿namespace LawrApp.Layouts.MaterialControl
{
	partial class frmReportar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnDesmarcar = new MetroFramework.Controls.MetroButton();
			this.btneliminar = new MetroFramework.Controls.MetroButton();
			this.btnSeleccionar = new MetroFramework.Controls.MetroButton();
			this.btnimprimir = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnSolucionar = new MetroFramework.Controls.MetroButton();
			this.btnReportar = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtfiltro = new System.Windows.Forms.TextBox();
			this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.cboSalon = new System.Windows.Forms.ComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.rEPORTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmItemSolucionar = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.cmsOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnDesmarcar);
			this.panelMain.Controls.Add(this.btneliminar);
			this.panelMain.Controls.Add(this.btnSeleccionar);
			this.panelMain.Controls.Add(this.btnimprimir);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnSolucionar);
			this.panelMain.Controls.Add(this.btnReportar);
			this.panelMain.Controls.Add(this.dgvListado);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.txtfiltro);
			this.panelMain.Controls.Add(this.cboTipoBusqueda);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.cboSalon);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 471);
			this.panelMain.TabIndex = 0;
			// 
			// btnDesmarcar
			// 
			this.btnDesmarcar.Enabled = false;
			this.btnDesmarcar.Location = new System.Drawing.Point(193, 437);
			this.btnDesmarcar.Name = "btnDesmarcar";
			this.btnDesmarcar.Size = new System.Drawing.Size(103, 31);
			this.btnDesmarcar.TabIndex = 10;
			this.btnDesmarcar.Text = "Desmarcar todo";
			this.btnDesmarcar.UseSelectable = true;
			this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.Enabled = false;
			this.btneliminar.Location = new System.Drawing.Point(302, 437);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(75, 31);
			this.btneliminar.TabIndex = 7;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.UseSelectable = true;
			this.btneliminar.Click += new System.EventHandler(this.btneliminardd_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(84, 437);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(103, 31);
			this.btnSeleccionar.TabIndex = 9;
			this.btnSeleccionar.Text = "Marcar todos";
			this.btnSeleccionar.UseSelectable = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnimprimir
			// 
			this.btnimprimir.Location = new System.Drawing.Point(500, 437);
			this.btnimprimir.Name = "btnimprimir";
			this.btnimprimir.Size = new System.Drawing.Size(75, 31);
			this.btnimprimir.TabIndex = 6;
			this.btnimprimir.Text = "Imprimir";
			this.btnimprimir.UseSelectable = true;
			this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 437);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnSolucionar
			// 
			this.btnSolucionar.Location = new System.Drawing.Point(581, 437);
			this.btnSolucionar.Name = "btnSolucionar";
			this.btnSolucionar.Size = new System.Drawing.Size(75, 31);
			this.btnSolucionar.TabIndex = 5;
			this.btnSolucionar.Text = "Solucionar";
			this.btnSolucionar.UseSelectable = true;
			this.btnSolucionar.Click += new System.EventHandler(this.btnSolucionar_Click);
			// 
			// btnReportar
			// 
			this.btnReportar.Location = new System.Drawing.Point(662, 437);
			this.btnReportar.Name = "btnReportar";
			this.btnReportar.Size = new System.Drawing.Size(75, 31);
			this.btnReportar.TabIndex = 5;
			this.btnReportar.Text = "Reportar";
			this.btnReportar.UseSelectable = true;
			this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.AllowUserToResizeColumns = false;
			this.dgvListado.AllowUserToResizeRows = false;
			this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Location = new System.Drawing.Point(3, 70);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.Height = 28;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.ShowCellErrors = false;
			this.dgvListado.ShowCellToolTips = false;
			this.dgvListado.ShowRowErrors = false;
			this.dgvListado.Size = new System.Drawing.Size(734, 349);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 4;
			this.dgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellClick);
			this.dgvListado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellValueChanged);
			this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged_1);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			this.dgvListado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListado_MouseDown);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(456, 13);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(39, 19);
			this.metroLabel3.TabIndex = 7;
			this.metroLabel3.Text = "Filtro";
			// 
			// txtfiltro
			// 
			this.txtfiltro.Enabled = false;
			this.txtfiltro.Location = new System.Drawing.Point(456, 35);
			this.txtfiltro.Name = "txtfiltro";
			this.txtfiltro.Size = new System.Drawing.Size(281, 29);
			this.txtfiltro.TabIndex = 3;
			this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
			// 
			// cboTipoBusqueda
			// 
			this.cboTipoBusqueda.Enabled = false;
			this.cboTipoBusqueda.FormattingEnabled = true;
			this.cboTipoBusqueda.Location = new System.Drawing.Point(232, 35);
			this.cboTipoBusqueda.Name = "cboTipoBusqueda";
			this.cboTipoBusqueda.Size = new System.Drawing.Size(218, 29);
			this.cboTipoBusqueda.TabIndex = 2;
			this.cboTipoBusqueda.SelectionChangeCommitted += new System.EventHandler(this.cboTipoBusqueda_SelectionChangeCommitted);
			this.cboTipoBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipoBusqueda_KeyDown);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(232, 13);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(47, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Buscar";
			// 
			// cboSalon
			// 
			this.cboSalon.FormattingEnabled = true;
			this.cboSalon.Location = new System.Drawing.Point(3, 35);
			this.cboSalon.Name = "cboSalon";
			this.cboSalon.Size = new System.Drawing.Size(223, 29);
			this.cboSalon.TabIndex = 3;
			this.cboSalon.SelectionChangeCommitted += new System.EventHandler(this.cboSalon_SelectionChangeCommitted);
			this.cboSalon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSalon_KeyDown);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 13);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(41, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Salon";
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(30, 574);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 154;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// cmsOptions
			// 
			this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEPORTARToolStripMenuItem,
            this.tsmItemSolucionar,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator1});
			this.cmsOptions.Name = "cmsOptions";
			this.cmsOptions.Size = new System.Drawing.Size(131, 76);
			// 
			// rEPORTARToolStripMenuItem
			// 
			this.rEPORTARToolStripMenuItem.Name = "rEPORTARToolStripMenuItem";
			this.rEPORTARToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.rEPORTARToolStripMenuItem.Text = "Reportar";
			this.rEPORTARToolStripMenuItem.Click += new System.EventHandler(this.rEPORTARToolStripMenuItem_Click);
			// 
			// tsmItemSolucionar
			// 
			this.tsmItemSolucionar.Name = "tsmItemSolucionar";
			this.tsmItemSolucionar.Size = new System.Drawing.Size(130, 22);
			this.tsmItemSolucionar.Text = "Solucionar";
			this.tsmItemSolucionar.Click += new System.EventHandler(this.tsmItemSolucionar_Click);
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
			// 
			// frmReportar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmReportar";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Reportar Material";
			this.Load += new System.EventHandler(this.frmReportar_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.cmsOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtfiltro;
		private System.Windows.Forms.ComboBox cboTipoBusqueda;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.ComboBox cboSalon;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridView dgvListado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnSolucionar;
		private MetroFramework.Controls.MetroButton btnReportar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.ContextMenuStrip cmsOptions;
		private System.Windows.Forms.ToolStripMenuItem rEPORTARToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmItemSolucionar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private MetroFramework.Controls.MetroButton btnimprimir;
		private MetroFramework.Controls.MetroButton btnSeleccionar;
		private MetroFramework.Controls.MetroButton btneliminar;
		private MetroFramework.Controls.MetroButton btnDesmarcar;
	}
}