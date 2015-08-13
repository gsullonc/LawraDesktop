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
			this.spcAsignacion = new System.Windows.Forms.SplitContainer();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnAgregar = new MetroFramework.Controls.MetroButton();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.cboSalones = new System.Windows.Forms.ComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnEliminar = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKeyMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCodMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcAsignacion)).BeginInit();
			this.spcAsignacion.Panel1.SuspendLayout();
			this.spcAsignacion.Panel2.SuspendLayout();
			this.spcAsignacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.spcAsignacion);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(740, 406);
			this.panelMain.TabIndex = 0;
			// 
			// spcAsignacion
			// 
			this.spcAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcAsignacion.Location = new System.Drawing.Point(0, 0);
			this.spcAsignacion.Name = "spcAsignacion";
			// 
			// spcAsignacion.Panel1
			// 
			this.spcAsignacion.Panel1.Controls.Add(this.pgsLoad);
			this.spcAsignacion.Panel1.Controls.Add(this.btnSalir);
			this.spcAsignacion.Panel1.Controls.Add(this.btnAgregar);
			this.spcAsignacion.Panel1.Controls.Add(this.nudCantidad);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel6);
			this.spcAsignacion.Panel1.Controls.Add(this.txtModelo);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel5);
			this.spcAsignacion.Panel1.Controls.Add(this.txtCategoria);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel4);
			this.spcAsignacion.Panel1.Controls.Add(this.txtMarca);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel3);
			this.spcAsignacion.Panel1.Controls.Add(this.btnbuscar);
			this.spcAsignacion.Panel1.Controls.Add(this.txtDescripcion);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel2);
			this.spcAsignacion.Panel1.Controls.Add(this.cboSalones);
			this.spcAsignacion.Panel1.Controls.Add(this.metroLabel1);
			// 
			// spcAsignacion.Panel2
			// 
			this.spcAsignacion.Panel2.Controls.Add(this.btnEliminar);
			this.spcAsignacion.Panel2.Controls.Add(this.dgvListado);
			this.spcAsignacion.Size = new System.Drawing.Size(740, 406);
			this.spcAsignacion.SplitterDistance = 306;
			this.spcAsignacion.TabIndex = 0;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(282, 14);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 155;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 372);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 14;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Location = new System.Drawing.Point(228, 372);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 31);
			this.btnAgregar.TabIndex = 13;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseSelectable = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// nudCantidad
			// 
			this.nudCantidad.Enabled = false;
			this.nudCantidad.Location = new System.Drawing.Point(3, 310);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(300, 29);
			this.nudCantidad.TabIndex = 3;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(1, 288);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(62, 19);
			this.metroLabel6.TabIndex = 11;
			this.metroLabel6.Text = "Cantidad";
			// 
			// txtModelo
			// 
			this.txtModelo.Enabled = false;
			this.txtModelo.Location = new System.Drawing.Point(3, 252);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(300, 29);
			this.txtModelo.TabIndex = 10;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(0, 230);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(55, 19);
			this.metroLabel5.TabIndex = 9;
			this.metroLabel5.Text = "Modelo";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Enabled = false;
			this.txtCategoria.Location = new System.Drawing.Point(1, 198);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(302, 29);
			this.txtCategoria.TabIndex = 8;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(-2, 176);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(67, 19);
			this.metroLabel4.TabIndex = 7;
			this.metroLabel4.Text = "Categoria";
			// 
			// txtMarca
			// 
			this.txtMarca.Enabled = false;
			this.txtMarca.Location = new System.Drawing.Point(3, 144);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(300, 29);
			this.txtMarca.TabIndex = 6;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 122);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(46, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Marca";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Enabled = false;
			this.btnbuscar.Location = new System.Drawing.Point(258, 90);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(45, 29);
			this.btnbuscar.TabIndex = 2;
			this.btnbuscar.Text = "....";
			this.btnbuscar.UseSelectable = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(3, 90);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(249, 29);
			this.txtDescripcion.TabIndex = 3;
			this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 68);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(57, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Material";
			// 
			// cboSalones
			// 
			this.cboSalones.FormattingEnabled = true;
			this.cboSalones.Location = new System.Drawing.Point(3, 36);
			this.cboSalones.Name = "cboSalones";
			this.cboSalones.Size = new System.Drawing.Size(300, 29);
			this.cboSalones.TabIndex = 1;
			this.cboSalones.SelectionChangeCommitted += new System.EventHandler(this.cboSalones_SelectionChangeCommitted);
			this.cboSalones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(1, 14);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(41, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Salon";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(355, 372);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 31);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseSelectable = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colKeyMaterial,
            this.colCodMaterial,
            this.colDescripcion,
            this.colCategoria});
			this.dgvListado.Location = new System.Drawing.Point(10, 36);
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
			this.dgvListado.ShowCellErrors = false;
			this.dgvListado.ShowCellToolTips = false;
			this.dgvListado.ShowEditingIcon = false;
			this.dgvListado.ShowRowErrors = false;
			this.dgvListado.Size = new System.Drawing.Size(417, 303);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 4;
			this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo Aula";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colKeyMaterial
			// 
			this.colKeyMaterial.FillWeight = 50F;
			this.colKeyMaterial.HeaderText = "Key";
			this.colKeyMaterial.Name = "colKeyMaterial";
			this.colKeyMaterial.ReadOnly = true;
			// 
			// colCodMaterial
			// 
			this.colCodMaterial.HeaderText = "Codigo Material";
			this.colCodMaterial.Name = "colCodMaterial";
			this.colCodMaterial.ReadOnly = true;
			this.colCodMaterial.Visible = false;
			// 
			// colDescripcion
			// 
			this.colDescripcion.FillWeight = 96.8319F;
			this.colDescripcion.HeaderText = "Descripcion";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colCategoria
			// 
			this.colCategoria.FillWeight = 40.21895F;
			this.colCategoria.HeaderText = "Cantidad";
			this.colCategoria.Name = "colCategoria";
			this.colCategoria.ReadOnly = true;
			// 
			// frmAsignarMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 508);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmAsignarMaterial";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Asignar Material";
			this.Load += new System.EventHandler(this.frmAsignarMaterial_Load);
			this.panelMain.ResumeLayout(false);
			this.spcAsignacion.Panel1.ResumeLayout(false);
			this.spcAsignacion.Panel1.PerformLayout();
			this.spcAsignacion.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcAsignacion)).EndInit();
			this.spcAsignacion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.SplitContainer spcAsignacion;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtMarca;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.ComboBox cboSalones;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.TextBox txtModelo;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox txtCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnAgregar;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private System.Windows.Forms.DataGridView dgvListado;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKeyMaterial;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodMaterial;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
	}
}