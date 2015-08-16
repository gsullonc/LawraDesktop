namespace LawrApp.Layouts.MaterialControl
{
	partial class frmInformeIngresosPorMaterial
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.tabcontrolMain = new MetroFramework.Controls.MetroTabControl();
			this.tabpagListadoIngreso = new MetroFramework.Controls.MetroTabPage();
			this.panelListado = new System.Windows.Forms.Panel();
			this.btnImprimir = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtFiltroIngreso = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtFiltroFecha = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtFiltroMaterial = new System.Windows.Forms.TextBox();
			this.dgvListadoMaterial = new System.Windows.Forms.DataGridView();
			this.btnCerrar = new MetroFramework.Controls.MetroButton();
			this.btnDetalle = new MetroFramework.Controls.MetroButton();
			this.tabDetalleIngresos = new MetroFramework.Controls.MetroTabPage();
			this.panelDetalle = new System.Windows.Forms.Panel();
			this.btmImprimir = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.txtFiltrarIngreso = new System.Windows.Forms.TextBox();
			this.dgvListadoDetalle = new System.Windows.Forms.DataGridView();
			this.panelMain.SuspendLayout();
			this.tabcontrolMain.SuspendLayout();
			this.tabpagListadoIngreso.SuspendLayout();
			this.panelListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterial)).BeginInit();
			this.tabDetalleIngresos.SuspendLayout();
			this.panelDetalle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.pgsLoad);
			this.panelMain.Controls.Add(this.tabcontrolMain);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 498);
			this.panelMain.TabIndex = 0;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(18, 477);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(16, 18);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 153;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// tabcontrolMain
			// 
			this.tabcontrolMain.Controls.Add(this.tabpagListadoIngreso);
			this.tabcontrolMain.Controls.Add(this.tabDetalleIngresos);
			this.tabcontrolMain.Location = new System.Drawing.Point(11, 3);
			this.tabcontrolMain.Name = "tabcontrolMain";
			this.tabcontrolMain.SelectedIndex = 0;
			this.tabcontrolMain.Size = new System.Drawing.Size(716, 472);
			this.tabcontrolMain.Style = MetroFramework.MetroColorStyle.Green;
			this.tabcontrolMain.TabIndex = 23;
			this.tabcontrolMain.UseSelectable = true;
			// 
			// tabpagListadoIngreso
			// 
			this.tabpagListadoIngreso.Controls.Add(this.panelListado);
			this.tabpagListadoIngreso.HorizontalScrollbarBarColor = true;
			this.tabpagListadoIngreso.HorizontalScrollbarHighlightOnWheel = false;
			this.tabpagListadoIngreso.HorizontalScrollbarSize = 1;
			this.tabpagListadoIngreso.Location = new System.Drawing.Point(4, 38);
			this.tabpagListadoIngreso.Name = "tabpagListadoIngreso";
			this.tabpagListadoIngreso.Size = new System.Drawing.Size(708, 430);
			this.tabpagListadoIngreso.TabIndex = 0;
			this.tabpagListadoIngreso.Text = "Listado de Ingresos";
			this.tabpagListadoIngreso.VerticalScrollbarBarColor = true;
			this.tabpagListadoIngreso.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagListadoIngreso.VerticalScrollbarSize = 1;
			// 
			// panelListado
			// 
			this.panelListado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelListado.Controls.Add(this.btnImprimir);
			this.panelListado.Controls.Add(this.btnEliminar);
			this.panelListado.Controls.Add(this.btnModificar);
			this.panelListado.Controls.Add(this.metroLabel4);
			this.panelListado.Controls.Add(this.txtFiltroIngreso);
			this.panelListado.Controls.Add(this.metroLabel3);
			this.panelListado.Controls.Add(this.txtFiltroFecha);
			this.panelListado.Controls.Add(this.metroLabel1);
			this.panelListado.Controls.Add(this.txtFiltroMaterial);
			this.panelListado.Controls.Add(this.dgvListadoMaterial);
			this.panelListado.Controls.Add(this.btnCerrar);
			this.panelListado.Controls.Add(this.btnDetalle);
			this.panelListado.Location = new System.Drawing.Point(0, 0);
			this.panelListado.Name = "panelListado";
			this.panelListado.Size = new System.Drawing.Size(700, 427);
			this.panelListado.TabIndex = 16;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(339, 387);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(85, 37);
			this.btnImprimir.TabIndex = 6;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseSelectable = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(430, 387);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(85, 37);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(521, 387);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 37);
			this.btnModificar.TabIndex = 8;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(181, 18);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(52, 19);
			this.metroLabel4.TabIndex = 18;
			this.metroLabel4.Text = "Ingreso";
			// 
			// txtFiltroIngreso
			// 
			this.txtFiltroIngreso.Enabled = false;
			this.txtFiltroIngreso.Location = new System.Drawing.Point(181, 40);
			this.txtFiltroIngreso.Name = "txtFiltroIngreso";
			this.txtFiltroIngreso.Size = new System.Drawing.Size(111, 29);
			this.txtFiltroIngreso.TabIndex = 2;
			this.txtFiltroIngreso.TextChanged += new System.EventHandler(this.txtFiltroIngreso_TextChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 18);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(43, 19);
			this.metroLabel3.TabIndex = 16;
			this.metroLabel3.Text = "Fecha";
			// 
			// txtFiltroFecha
			// 
			this.txtFiltroFecha.Enabled = false;
			this.txtFiltroFecha.Location = new System.Drawing.Point(3, 40);
			this.txtFiltroFecha.Name = "txtFiltroFecha";
			this.txtFiltroFecha.Size = new System.Drawing.Size(172, 29);
			this.txtFiltroFecha.TabIndex = 1;
			this.txtFiltroFecha.TextChanged += new System.EventHandler(this.txtFiltroFecha_TextChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(301, 18);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(61, 19);
			this.metroLabel1.TabIndex = 11;
			this.metroLabel1.Text = "Material ";
			// 
			// txtFiltroMaterial
			// 
			this.txtFiltroMaterial.Enabled = false;
			this.txtFiltroMaterial.Location = new System.Drawing.Point(298, 40);
			this.txtFiltroMaterial.Name = "txtFiltroMaterial";
			this.txtFiltroMaterial.Size = new System.Drawing.Size(399, 29);
			this.txtFiltroMaterial.TabIndex = 3;
			this.txtFiltroMaterial.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
			// 
			// dgvListadoMaterial
			// 
			this.dgvListadoMaterial.AllowUserToAddRows = false;
			this.dgvListadoMaterial.AllowUserToDeleteRows = false;
			this.dgvListadoMaterial.AllowUserToResizeColumns = false;
			this.dgvListadoMaterial.AllowUserToResizeRows = false;
			this.dgvListadoMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListadoMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListadoMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListadoMaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListadoMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListadoMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListadoMaterial.Location = new System.Drawing.Point(3, 75);
			this.dgvListadoMaterial.MultiSelect = false;
			this.dgvListadoMaterial.Name = "dgvListadoMaterial";
			this.dgvListadoMaterial.ReadOnly = true;
			this.dgvListadoMaterial.RowHeadersVisible = false;
			this.dgvListadoMaterial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListadoMaterial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListadoMaterial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListadoMaterial.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListadoMaterial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListadoMaterial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListadoMaterial.RowTemplate.Height = 28;
			this.dgvListadoMaterial.RowTemplate.ReadOnly = true;
			this.dgvListadoMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListadoMaterial.ShowCellErrors = false;
			this.dgvListadoMaterial.ShowCellToolTips = false;
			this.dgvListadoMaterial.ShowEditingIcon = false;
			this.dgvListadoMaterial.ShowRowErrors = false;
			this.dgvListadoMaterial.Size = new System.Drawing.Size(694, 286);
			this.dgvListadoMaterial.StandardTab = true;
			this.dgvListadoMaterial.TabIndex = 12;
			this.dgvListadoMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoMaterial_CellDoubleClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(3, 387);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(85, 37);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "Salir";
			this.btnCerrar.UseSelectable = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnDetalle
			// 
			this.btnDetalle.Enabled = false;
			this.btnDetalle.Location = new System.Drawing.Point(612, 387);
			this.btnDetalle.Name = "btnDetalle";
			this.btnDetalle.Size = new System.Drawing.Size(85, 37);
			this.btnDetalle.TabIndex = 9;
			this.btnDetalle.Text = "Detalle ";
			this.btnDetalle.UseSelectable = true;
			this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
			// 
			// tabDetalleIngresos
			// 
			this.tabDetalleIngresos.Controls.Add(this.panelDetalle);
			this.tabDetalleIngresos.HorizontalScrollbarBarColor = true;
			this.tabDetalleIngresos.HorizontalScrollbarHighlightOnWheel = false;
			this.tabDetalleIngresos.HorizontalScrollbarSize = 1;
			this.tabDetalleIngresos.Location = new System.Drawing.Point(4, 38);
			this.tabDetalleIngresos.Name = "tabDetalleIngresos";
			this.tabDetalleIngresos.Size = new System.Drawing.Size(708, 430);
			this.tabDetalleIngresos.TabIndex = 1;
			this.tabDetalleIngresos.Text = "Detalle de los Ingresos";
			this.tabDetalleIngresos.VerticalScrollbarBarColor = true;
			this.tabDetalleIngresos.VerticalScrollbarHighlightOnWheel = false;
			this.tabDetalleIngresos.VerticalScrollbarSize = 1;
			// 
			// panelDetalle
			// 
			this.panelDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelDetalle.Controls.Add(this.btmImprimir);
			this.panelDetalle.Controls.Add(this.metroLabel2);
			this.panelDetalle.Controls.Add(this.btnCancelar);
			this.panelDetalle.Controls.Add(this.txtFiltrarIngreso);
			this.panelDetalle.Controls.Add(this.dgvListadoDetalle);
			this.panelDetalle.Location = new System.Drawing.Point(3, 0);
			this.panelDetalle.Name = "panelDetalle";
			this.panelDetalle.Size = new System.Drawing.Size(702, 427);
			this.panelDetalle.TabIndex = 28;
			// 
			// btmImprimir
			// 
			this.btmImprimir.Location = new System.Drawing.Point(614, 387);
			this.btmImprimir.Name = "btmImprimir";
			this.btmImprimir.Size = new System.Drawing.Size(85, 37);
			this.btmImprimir.TabIndex = 28;
			this.btmImprimir.Text = "Imprimir";
			this.btmImprimir.UseSelectable = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 14);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(57, 19);
			this.metroLabel2.TabIndex = 24;
			this.metroLabel2.Text = "Ingresos";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(3, 387);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 37);
			this.btnCancelar.TabIndex = 27;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseSelectable = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtFiltrarIngreso
			// 
			this.txtFiltrarIngreso.Location = new System.Drawing.Point(3, 36);
			this.txtFiltrarIngreso.Name = "txtFiltrarIngreso";
			this.txtFiltrarIngreso.Size = new System.Drawing.Size(696, 29);
			this.txtFiltrarIngreso.TabIndex = 23;
			this.txtFiltrarIngreso.TextChanged += new System.EventHandler(this.txtFiltrarIngreso_TextChanged);
			// 
			// dgvListadoDetalle
			// 
			this.dgvListadoDetalle.AllowUserToAddRows = false;
			this.dgvListadoDetalle.AllowUserToDeleteRows = false;
			this.dgvListadoDetalle.AllowUserToResizeColumns = false;
			this.dgvListadoDetalle.AllowUserToResizeRows = false;
			this.dgvListadoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListadoDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvListadoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvListadoDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListadoDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListadoDetalle.Location = new System.Drawing.Point(3, 71);
			this.dgvListadoDetalle.MultiSelect = false;
			this.dgvListadoDetalle.Name = "dgvListadoDetalle";
			this.dgvListadoDetalle.ReadOnly = true;
			this.dgvListadoDetalle.RowHeadersVisible = false;
			this.dgvListadoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListadoDetalle.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListadoDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListadoDetalle.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvListadoDetalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListadoDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListadoDetalle.RowTemplate.Height = 28;
			this.dgvListadoDetalle.RowTemplate.ReadOnly = true;
			this.dgvListadoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListadoDetalle.ShowCellErrors = false;
			this.dgvListadoDetalle.ShowCellToolTips = false;
			this.dgvListadoDetalle.ShowEditingIcon = false;
			this.dgvListadoDetalle.ShowRowErrors = false;
			this.dgvListadoDetalle.Size = new System.Drawing.Size(696, 301);
			this.dgvListadoDetalle.StandardTab = true;
			this.dgvListadoDetalle.TabIndex = 7;
			// 
			// frmInformeIngresosPorMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmInformeIngresosPorMaterial";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Informe de los Ingresos de un Material";
			this.Load += new System.EventHandler(this.frmInformeIngresosPorMaterial_Load);
			this.panelMain.ResumeLayout(false);
			this.tabcontrolMain.ResumeLayout(false);
			this.tabpagListadoIngreso.ResumeLayout(false);
			this.panelListado.ResumeLayout(false);
			this.panelListado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterial)).EndInit();
			this.tabDetalleIngresos.ResumeLayout(false);
			this.panelDetalle.ResumeLayout(false);
			this.panelDetalle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private MetroFramework.Controls.MetroTabControl tabcontrolMain;
		private MetroFramework.Controls.MetroTabPage tabpagListadoIngreso;
		private MetroFramework.Controls.MetroTabPage tabDetalleIngresos;
		private System.Windows.Forms.DataGridView dgvListadoMaterial;
		private System.Windows.Forms.TextBox txtFiltroMaterial;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtFiltrarIngreso;
		private System.Windows.Forms.DataGridView dgvListadoDetalle;
		private MetroFramework.Controls.MetroButton btnCerrar;
		private MetroFramework.Controls.MetroButton btnDetalle;
		private MetroFramework.Controls.MetroButton btnCancelar;
		private System.Windows.Forms.Panel panelDetalle;
		private System.Windows.Forms.Panel panelListado;
		private MetroFramework.Controls.MetroButton btmImprimir;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.TextBox txtFiltroIngreso;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtFiltroFecha;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroButton btnImprimir;
	}
}