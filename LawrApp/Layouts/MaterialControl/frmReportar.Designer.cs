namespace LawrApp.Layouts.MaterialControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboSalon = new System.Windows.Forms.ComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnReportar = new MetroFramework.Controls.MetroButton();
			this.btnSolucionar = new MetroFramework.Controls.MetroButton();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.btnSolucionar);
			this.panel1.Controls.Add(this.btnReportar);
			this.panel1.Controls.Add(this.dgvListado);
			this.panel1.Controls.Add(this.metroLabel3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.cboTipoBusqueda);
			this.panel1.Controls.Add(this.metroLabel2);
			this.panel1.Controls.Add(this.cboSalon);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(590, 379);
			this.panel1.TabIndex = 0;
			// 
			// cboSalon
			// 
			this.cboSalon.FormattingEnabled = true;
			this.cboSalon.Location = new System.Drawing.Point(3, 35);
			this.cboSalon.Name = "cboSalon";
			this.cboSalon.Size = new System.Drawing.Size(195, 29);
			this.cboSalon.TabIndex = 3;
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
			// cboTipoBusqueda
			// 
			this.cboTipoBusqueda.FormattingEnabled = true;
			this.cboTipoBusqueda.Location = new System.Drawing.Point(210, 35);
			this.cboTipoBusqueda.Name = "cboTipoBusqueda";
			this.cboTipoBusqueda.Size = new System.Drawing.Size(184, 29);
			this.cboTipoBusqueda.TabIndex = 5;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(210, 13);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(47, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Buscar";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(400, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 29);
			this.textBox1.TabIndex = 6;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(400, 13);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(39, 19);
			this.metroLabel3.TabIndex = 7;
			this.metroLabel3.Text = "Filtro";
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
            this.ColEstado});
			this.dgvListado.Location = new System.Drawing.Point(3, 70);
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
			this.dgvListado.Size = new System.Drawing.Size(584, 238);
			this.dgvListado.StandardTab = true;
			this.dgvListado.TabIndex = 8;
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
			this.colDescripcion.FillWeight = 120.8319F;
			this.colDescripcion.HeaderText = "Descripcion";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colCategoria
			// 
			this.colCategoria.FillWeight = 45.21895F;
			this.colCategoria.HeaderText = "Cantidad";
			this.colCategoria.Name = "colCategoria";
			this.colCategoria.ReadOnly = true;
			// 
			// ColEstado
			// 
			this.ColEstado.FillWeight = 50F;
			this.ColEstado.HeaderText = "Estado";
			this.ColEstado.Name = "ColEstado";
			this.ColEstado.ReadOnly = true;
			// 
			// btnReportar
			// 
			this.btnReportar.Location = new System.Drawing.Point(512, 329);
			this.btnReportar.Name = "btnReportar";
			this.btnReportar.Size = new System.Drawing.Size(75, 31);
			this.btnReportar.TabIndex = 16;
			this.btnReportar.Text = "Reportar";
			this.btnReportar.UseSelectable = true;
			// 
			// btnSolucionar
			// 
			this.btnSolucionar.Location = new System.Drawing.Point(415, 329);
			this.btnSolucionar.Name = "btnSolucionar";
			this.btnSolucionar.Size = new System.Drawing.Size(75, 31);
			this.btnSolucionar.TabIndex = 17;
			this.btnSolucionar.Text = "Solucionar";
			this.btnSolucionar.UseSelectable = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 329);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 18;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(56, 482);
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
			// frmReportar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 508);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmReportar";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Reportar Material";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox cboTipoBusqueda;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.ComboBox cboSalon;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnSolucionar;
		private MetroFramework.Controls.MetroButton btnReportar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
	}
}