namespace LawrApp.Layouts.MaterialControl
{
	partial class frmAsignarMaterial
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.cboSalones = new System.Windows.Forms.ComboBox();
			this.btnAgregar = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtfiltro = new System.Windows.Forms.TextBox();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.splitContainer1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 499);
			this.panelMain.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pgsLoad);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
			this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
			this.splitContainer1.Panel1.Controls.Add(this.cboSalones);
			this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
			this.splitContainer1.Panel1.Controls.Add(this.nudCantidad);
			this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel6);
			this.splitContainer1.Panel1.Controls.Add(this.btnbuscar);
			this.splitContainer1.Panel1.Controls.Add(this.txtModelo);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel5);
			this.splitContainer1.Panel1.Controls.Add(this.txtMarca);
			this.splitContainer1.Panel1.Controls.Add(this.txtCategoria);
			this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvListado);
			this.splitContainer1.Panel2.Controls.Add(this.btnEliminar);
			this.splitContainer1.Panel2.Controls.Add(this.metroLabel7);
			this.splitContainer1.Panel2.Controls.Add(this.txtfiltro);
			this.splitContainer1.Size = new System.Drawing.Size(740, 499);
			this.splitContainer1.SplitterDistance = 279;
			this.splitContainer1.TabIndex = 12;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(255, 22);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 171;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 22);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(41, 19);
			this.metroLabel1.TabIndex = 156;
			this.metroLabel1.Text = "Salon";
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(2, 465);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 170;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// cboSalones
			// 
			this.cboSalones.FormattingEnabled = true;
			this.cboSalones.Location = new System.Drawing.Point(2, 44);
			this.cboSalones.Name = "cboSalones";
			this.cboSalones.Size = new System.Drawing.Size(274, 29);
			this.cboSalones.TabIndex = 157;
			this.cboSalones.SelectionChangeCommitted += new System.EventHandler(this.cboSalones_SelectionChangeCommitted);
			this.cboSalones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSalones_KeyDown);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Location = new System.Drawing.Point(201, 465);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 31);
			this.btnAgregar.TabIndex = 169;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseSelectable = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(2, 87);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(57, 19);
			this.metroLabel2.TabIndex = 159;
			this.metroLabel2.Text = "Material";
			// 
			// nudCantidad
			// 
			this.nudCantidad.Enabled = false;
			this.nudCantidad.Location = new System.Drawing.Point(3, 349);
			this.nudCantidad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(273, 29);
			this.nudCantidad.TabIndex = 160;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(2, 109);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(238, 29);
			this.txtDescripcion.TabIndex = 161;
			this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSalones_KeyDown);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(0, 327);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(62, 19);
			this.metroLabel6.TabIndex = 168;
			this.metroLabel6.Text = "Cantidad";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Enabled = false;
			this.btnbuscar.Location = new System.Drawing.Point(241, 109);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(35, 29);
			this.btnbuscar.TabIndex = 158;
			this.btnbuscar.Text = "....";
			this.btnbuscar.UseSelectable = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtModelo
			// 
			this.txtModelo.Enabled = false;
			this.txtModelo.Location = new System.Drawing.Point(3, 284);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(273, 29);
			this.txtModelo.TabIndex = 167;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(2, 198);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(46, 19);
			this.metroLabel3.TabIndex = 162;
			this.metroLabel3.Text = "Marca";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(3, 262);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(55, 19);
			this.metroLabel5.TabIndex = 166;
			this.metroLabel5.Text = "Modelo";
			// 
			// txtMarca
			// 
			this.txtMarca.Enabled = false;
			this.txtMarca.Location = new System.Drawing.Point(2, 220);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(274, 29);
			this.txtMarca.TabIndex = 163;
			// 
			// txtCategoria
			// 
			this.txtCategoria.Enabled = false;
			this.txtCategoria.Location = new System.Drawing.Point(0, 166);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(276, 29);
			this.txtCategoria.TabIndex = 165;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(2, 144);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(67, 19);
			this.metroLabel4.TabIndex = 164;
			this.metroLabel4.Text = "Categoria";
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
			this.dgvListado.Location = new System.Drawing.Point(3, 79);
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
			this.dgvListado.Size = new System.Drawing.Size(451, 349);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 160;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			this.dgvListado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellValueChanged);
			this.dgvListado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListado_CurrentCellDirtyStateChanged);
			this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(379, 465);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 31);
			this.btnEliminar.TabIndex = 159;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(-1, 22);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(57, 19);
			this.metroLabel7.TabIndex = 158;
			this.metroLabel7.Text = "Material";
			// 
			// txtfiltro
			// 
			this.txtfiltro.Enabled = false;
			this.txtfiltro.Location = new System.Drawing.Point(3, 44);
			this.txtfiltro.Name = "txtfiltro";
			this.txtfiltro.Size = new System.Drawing.Size(451, 29);
			this.txtfiltro.TabIndex = 157;
			this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
			// 
			// frmAsignarMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmAsignarMaterial";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "frmAsigMaterial";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsigMaterial_FormClosing);
			this.Load += new System.EventHandler(this.frmAsigMaterial_Load);
			this.panelMain.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnSalir;
		private System.Windows.Forms.ComboBox cboSalones;
		private MetroFramework.Controls.MetroButton btnAgregar;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private System.Windows.Forms.TextBox txtModelo;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.TextBox txtfiltro;
		private System.Windows.Forms.DataGridView dgvListado;

	}
}