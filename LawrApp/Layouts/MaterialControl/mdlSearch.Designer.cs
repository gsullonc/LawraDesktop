namespace LawrApp.Layouts.MaterialControl
{
	partial class mdlSearch
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
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnAgregar = new MetroFramework.Controls.MetroButton();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtfiltro = new System.Windows.Forms.TextBox();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.dgvListado);
			this.panel1.Controls.Add(this.btnbuscar);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Controls.Add(this.txtfiltro);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 298);
			this.panel1.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(290, 264);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(371, 264);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 31);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseSelectable = true;
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
            this.colDescripcion,
            this.colCategoria,
            this.colMarca,
            this.colModelo,
            this.colModifiedDate});
			this.dgvListado.Location = new System.Drawing.Point(7, 38);
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
			this.dgvListado.Size = new System.Drawing.Size(439, 212);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 3;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(378, 3);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(68, 29);
			this.btnbuscar.TabIndex = 2;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(7, 5);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(42, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Filtro:";
			// 
			// txtfiltro
			// 
			this.txtfiltro.Location = new System.Drawing.Point(50, 3);
			this.txtfiltro.Name = "txtfiltro";
			this.txtfiltro.Size = new System.Drawing.Size(323, 29);
			this.txtfiltro.TabIndex = 1;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(45, 374);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 153;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.ReadOnly = true;
			this.colCodigo.Visible = false;
			// 
			// colDescripcion
			// 
			this.colDescripcion.FillWeight = 73.8319F;
			this.colDescripcion.HeaderText = "Descripcion";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colCategoria
			// 
			this.colCategoria.FillWeight = 59.21895F;
			this.colCategoria.HeaderText = "Categoria";
			this.colCategoria.Name = "colCategoria";
			this.colCategoria.ReadOnly = true;
			// 
			// colMarca
			// 
			this.colMarca.FillWeight = 43.66789F;
			this.colMarca.HeaderText = "Marca";
			this.colMarca.Name = "colMarca";
			this.colMarca.ReadOnly = true;
			// 
			// colModelo
			// 
			this.colModelo.FillWeight = 53.62137F;
			this.colModelo.HeaderText = "Modelo";
			this.colModelo.Name = "colModelo";
			this.colModelo.ReadOnly = true;
			// 
			// colModifiedDate
			// 
			this.colModifiedDate.FillWeight = 90.6599F;
			this.colModifiedDate.HeaderText = "Ult. Modificación";
			this.colModifiedDate.Name = "colModifiedDate";
			this.colModifiedDate.ReadOnly = true;
			this.colModifiedDate.Visible = false;
			// 
			// mdlSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 400);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdlSearch";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Busqueda de Materiales";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtfiltro;
		private System.Windows.Forms.DataGridView dgvListado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnAgregar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModifiedDate;
	}
}