namespace LawrApp.Layouts.MaterialControl
{
	partial class frmInformeInventario
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
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.cboSalon = new System.Windows.Forms.ComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCondicion = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.dgvListado);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnGuardar);
			this.panelMain.Controls.Add(this.cboSalon);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(540, 471);
			this.panelMain.TabIndex = 0;
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
			this.dgvListado.ColumnHeadersHeight = 30;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCategorias,
            this.colCondicion});
			this.dgvListado.Location = new System.Drawing.Point(3, 57);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.RowHeadersVisible = false;
			this.dgvListado.RowHeadersWidth = 43;
			this.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListado.RowTemplate.Height = 30;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(534, 345);
			this.dgvListado.TabIndex = 7;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(381, 432);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 36);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(462, 432);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 36);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseSelectable = true;
			// 
			// cboSalon
			// 
			this.cboSalon.FormattingEnabled = true;
			this.cboSalon.Location = new System.Drawing.Point(3, 22);
			this.cboSalon.Name = "cboSalon";
			this.cboSalon.Size = new System.Drawing.Size(534, 29);
			this.cboSalon.TabIndex = 1;
			this.cboSalon.SelectionChangeCommitted += new System.EventHandler(this.cboSalon_SelectionChangeCommitted);
			this.cboSalon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSalon_KeyDown);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(45, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Salon ";
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(30, 574);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 155;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.Visible = false;
			// 
			// colDescripcion
			// 
			this.colDescripcion.FillWeight = 120F;
			this.colDescripcion.HeaderText = "Descripcion";
			this.colDescripcion.Name = "colDescripcion";
			// 
			// colCategorias
			// 
			this.colCategorias.FillWeight = 60F;
			this.colCategorias.HeaderText = "Categoria";
			this.colCategorias.Name = "colCategorias";
			// 
			// colCondicion
			// 
			this.colCondicion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colCondicion.FillWeight = 70F;
			this.colCondicion.HeaderText = "Condicion";
			this.colCondicion.Name = "colCondicion";
			// 
			// frmInformeInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmInformeInventario";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Registro Informe Inventario";
			this.Load += new System.EventHandler(this.frmInformeInventario_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.ComboBox cboSalon;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategorias;
		private System.Windows.Forms.DataGridViewComboBoxColumn colCondicion;
	}
}