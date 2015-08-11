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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.tabcontrolMain = new MetroFramework.Controls.MetroTabControl();
			this.tabpagListadoIngreso = new MetroFramework.Controls.MetroTabPage();
			this.tabDetalleIngresos = new MetroFramework.Controls.MetroTabPage();
			this.dgvListadoDetalle = new System.Windows.Forms.DataGridView();
			this.dgvListadoMaterial = new System.Windows.Forms.DataGridView();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtFiltrarIngreso = new System.Windows.Forms.TextBox();
			this.btnListar = new MetroFramework.Controls.MetroButton();
			this.btnCerrar = new MetroFramework.Controls.MetroButton();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.panelDetalle = new System.Windows.Forms.Panel();
			this.panelListado = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.tabcontrolMain.SuspendLayout();
			this.tabpagListadoIngreso.SuspendLayout();
			this.tabDetalleIngresos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterial)).BeginInit();
			this.panelDetalle.SuspendLayout();
			this.panelListado.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pgsLoad);
			this.panel1.Controls.Add(this.tabcontrolMain);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(740, 498);
			this.panel1.TabIndex = 0;
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
			this.tabcontrolMain.SelectedIndex = 1;
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
			this.tabpagListadoIngreso.HorizontalScrollbarSize = 10;
			this.tabpagListadoIngreso.Location = new System.Drawing.Point(4, 38);
			this.tabpagListadoIngreso.Name = "tabpagListadoIngreso";
			this.tabpagListadoIngreso.Size = new System.Drawing.Size(708, 430);
			this.tabpagListadoIngreso.TabIndex = 0;
			this.tabpagListadoIngreso.Text = "Listado de Ingresos";
			this.tabpagListadoIngreso.VerticalScrollbarBarColor = true;
			this.tabpagListadoIngreso.VerticalScrollbarHighlightOnWheel = false;
			this.tabpagListadoIngreso.VerticalScrollbarSize = 10;
			// 
			// tabDetalleIngresos
			// 
			this.tabDetalleIngresos.Controls.Add(this.panelDetalle);
			this.tabDetalleIngresos.HorizontalScrollbarBarColor = true;
			this.tabDetalleIngresos.HorizontalScrollbarHighlightOnWheel = false;
			this.tabDetalleIngresos.HorizontalScrollbarSize = 10;
			this.tabDetalleIngresos.Location = new System.Drawing.Point(4, 38);
			this.tabDetalleIngresos.Name = "tabDetalleIngresos";
			this.tabDetalleIngresos.Size = new System.Drawing.Size(708, 430);
			this.tabDetalleIngresos.TabIndex = 1;
			this.tabDetalleIngresos.Text = "Detalle de los Ingresos";
			this.tabDetalleIngresos.VerticalScrollbarBarColor = true;
			this.tabDetalleIngresos.VerticalScrollbarHighlightOnWheel = false;
			this.tabDetalleIngresos.VerticalScrollbarSize = 10;
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
			this.dgvListadoDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListadoDetalle_KeyDown);
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
			this.dgvListadoMaterial.Enabled = false;
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
			this.dgvListadoMaterial.Size = new System.Drawing.Size(694, 275);
			this.dgvListadoMaterial.StandardTab = true;
			this.dgvListadoMaterial.TabIndex = 12;
			this.dgvListadoMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoMaterial_CellDoubleClick);
			// 
			// txtFiltro
			// 
			this.txtFiltro.Enabled = false;
			this.txtFiltro.Location = new System.Drawing.Point(3, 40);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(694, 29);
			this.txtFiltro.TabIndex = 13;
			this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 18);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(61, 19);
			this.metroLabel1.TabIndex = 11;
			this.metroLabel1.Text = "Material ";
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
			// txtFiltrarIngreso
			// 
			this.txtFiltrarIngreso.Location = new System.Drawing.Point(3, 36);
			this.txtFiltrarIngreso.Name = "txtFiltrarIngreso";
			this.txtFiltrarIngreso.Size = new System.Drawing.Size(696, 29);
			this.txtFiltrarIngreso.TabIndex = 23;
			this.txtFiltrarIngreso.TextChanged += new System.EventHandler(this.txtFiltrarIngreso_TextChanged);
			// 
			// btnListar
			// 
			this.btnListar.Enabled = false;
			this.btnListar.Location = new System.Drawing.Point(612, 376);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(85, 37);
			this.btnListar.TabIndex = 14;
			this.btnListar.Text = "Listar";
			this.btnListar.UseSelectable = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(3, 376);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(85, 37);
			this.btnCerrar.TabIndex = 15;
			this.btnCerrar.Text = "Salir";
			this.btnCerrar.UseSelectable = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(526, 387);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(85, 37);
			this.btnEliminar.TabIndex = 26;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(614, 387);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 37);
			this.btnModificar.TabIndex = 25;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 387);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(85, 37);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// panelDetalle
			// 
			this.panelDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelDetalle.Controls.Add(this.metroLabel2);
			this.panelDetalle.Controls.Add(this.btnSalir);
			this.panelDetalle.Controls.Add(this.txtFiltrarIngreso);
			this.panelDetalle.Controls.Add(this.btnEliminar);
			this.panelDetalle.Controls.Add(this.dgvListadoDetalle);
			this.panelDetalle.Controls.Add(this.btnModificar);
			this.panelDetalle.Location = new System.Drawing.Point(3, 0);
			this.panelDetalle.Name = "panelDetalle";
			this.panelDetalle.Size = new System.Drawing.Size(702, 427);
			this.panelDetalle.TabIndex = 28;
			// 
			// panelListado
			// 
			this.panelListado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelListado.Controls.Add(this.metroLabel1);
			this.panelListado.Controls.Add(this.txtFiltro);
			this.panelListado.Controls.Add(this.dgvListadoMaterial);
			this.panelListado.Controls.Add(this.btnCerrar);
			this.panelListado.Controls.Add(this.btnListar);
			this.panelListado.Location = new System.Drawing.Point(0, 0);
			this.panelListado.Name = "panelListado";
			this.panelListado.Size = new System.Drawing.Size(700, 427);
			this.panelListado.TabIndex = 16;
			// 
			// frmInformeIngresosPorMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panel1);
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
			this.panel1.ResumeLayout(false);
			this.tabcontrolMain.ResumeLayout(false);
			this.tabpagListadoIngreso.ResumeLayout(false);
			this.tabDetalleIngresos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterial)).EndInit();
			this.panelDetalle.ResumeLayout(false);
			this.panelDetalle.PerformLayout();
			this.panelListado.ResumeLayout(false);
			this.panelListado.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private MetroFramework.Controls.MetroTabControl tabcontrolMain;
		private MetroFramework.Controls.MetroTabPage tabpagListadoIngreso;
		private MetroFramework.Controls.MetroTabPage tabDetalleIngresos;
		private System.Windows.Forms.DataGridView dgvListadoMaterial;
		private System.Windows.Forms.TextBox txtFiltro;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtFiltrarIngreso;
		private System.Windows.Forms.DataGridView dgvListadoDetalle;
		private MetroFramework.Controls.MetroButton btnCerrar;
		private MetroFramework.Controls.MetroButton btnListar;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroButton btnModificar;
		private System.Windows.Forms.Panel panelDetalle;
		private System.Windows.Forms.Panel panelListado;
	}
}