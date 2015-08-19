namespace LawrApp.Layouts.MaterialControl
{
	partial class mdlReporte
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
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btnguardar = new MetroFramework.Controls.MetroButton();
			this.txtDetalle = new System.Windows.Forms.TextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.cboCondicion = new System.Windows.Forms.ComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.lblValidateResponsable = new System.Windows.Forms.Label();
			this.toltipValid = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.lblValidateResponsable);
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btnguardar);
			this.panelMain.Controls.Add(this.txtDetalle);
			this.panelMain.Controls.Add(this.metroLabel4);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.txtResponsable);
			this.panelMain.Controls.Add(this.cboCondicion);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Controls.Add(this.txtDescripcion);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(340, 305);
			this.panelMain.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(189, 271);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(266, 271);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(71, 31);
			this.btnguardar.TabIndex = 4;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseSelectable = true;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// txtDetalle
			// 
			this.txtDetalle.Location = new System.Drawing.Point(3, 152);
			this.txtDetalle.Multiline = true;
			this.txtDetalle.Name = "txtDetalle";
			this.txtDetalle.Size = new System.Drawing.Size(334, 102);
			this.txtDetalle.TabIndex = 3;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(3, 130);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(49, 19);
			this.metroLabel4.TabIndex = 6;
			this.metroLabel4.Text = "Detalle";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(2, 71);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(82, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Responsable";
			// 
			// txtResponsable
			// 
			this.txtResponsable.Location = new System.Drawing.Point(3, 93);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(334, 29);
			this.txtResponsable.TabIndex = 2;
			this.txtResponsable.TextChanged += new System.EventHandler(this.txtResponsable_TextChanged);
			// 
			// cboCondicion
			// 
			this.cboCondicion.FormattingEnabled = true;
			this.cboCondicion.Items.AddRange(new object[] {
            "Req. Reparacion",
            "En Pesimo Estado"});
			this.cboCondicion.Location = new System.Drawing.Point(189, 34);
			this.cboCondicion.Name = "cboCondicion";
			this.cboCondicion.Size = new System.Drawing.Size(148, 29);
			this.cboCondicion.TabIndex = 1;
			this.cboCondicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCondicion_KeyDown);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(185, 12);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(68, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Condicion";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 12);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Material";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(3, 34);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(180, 29);
			this.txtDescripcion.TabIndex = 0;
			this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(30, 381);
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
			// lblValidateResponsable
			// 
			this.lblValidateResponsable.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateResponsable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateResponsable.ForeColor = System.Drawing.Color.Red;
			this.lblValidateResponsable.Location = new System.Drawing.Point(81, 74);
			this.lblValidateResponsable.Name = "lblValidateResponsable";
			this.lblValidateResponsable.Size = new System.Drawing.Size(24, 16);
			this.lblValidateResponsable.TabIndex = 63;
			this.lblValidateResponsable.Text = "*";
			this.lblValidateResponsable.Visible = false;
			// 
			// toltipValid
			// 
			this.toltipValid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValid.ToolTipTitle = "Requerido";
			// 
			// mdlReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 407);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdlReporte";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Reporte Material";
			this.Load += new System.EventHandler(this.mdlReporte_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TextBox txtDetalle;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtResponsable;
		private System.Windows.Forms.ComboBox cboCondicion;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btnguardar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.Label lblValidateResponsable;
		private System.Windows.Forms.ToolTip toltipValid;
	}
}