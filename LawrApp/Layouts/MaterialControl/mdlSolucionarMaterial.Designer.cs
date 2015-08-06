namespace LawrApp.Layouts.MaterialControl
{
	partial class mdlSolucionarMaterial
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
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btngGuardar = new MetroFramework.Controls.MetroButton();
			this.txtObervacion = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.dtpF_Solucion = new System.Windows.Forms.DateTimePicker();
			this.dtpF_Solcion = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.btnSalir);
			this.panelMain.Controls.Add(this.btngGuardar);
			this.panelMain.Controls.Add(this.txtObervacion);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.dtpF_Solucion);
			this.panelMain.Controls.Add(this.dtpF_Solcion);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Controls.Add(this.txtDescripcion);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(290, 271);
			this.panelMain.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(131, 237);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btngGuardar
			// 
			this.btngGuardar.Location = new System.Drawing.Point(211, 237);
			this.btngGuardar.Name = "btngGuardar";
			this.btngGuardar.Size = new System.Drawing.Size(75, 31);
			this.btngGuardar.TabIndex = 4;
			this.btngGuardar.Text = "Guardar";
			this.btngGuardar.UseSelectable = true;
			this.btngGuardar.Click += new System.EventHandler(this.btngGuardar_Click);
			// 
			// txtObervacion
			// 
			this.txtObervacion.Location = new System.Drawing.Point(2, 160);
			this.txtObervacion.Multiline = true;
			this.txtObervacion.Name = "txtObervacion";
			this.txtObervacion.Size = new System.Drawing.Size(284, 59);
			this.txtObervacion.TabIndex = 3;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(2, 138);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(83, 19);
			this.metroLabel2.TabIndex = 40;
			this.metroLabel2.Text = "Observacion";
			// 
			// dtpF_Solucion
			// 
			this.dtpF_Solucion.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpF_Solucion.CustomFormat = "yyyy-MM-dd";
			this.dtpF_Solucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpF_Solucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpF_Solucion.Location = new System.Drawing.Point(2, 96);
			this.dtpF_Solucion.Name = "dtpF_Solucion";
			this.dtpF_Solucion.Size = new System.Drawing.Size(284, 29);
			this.dtpF_Solucion.TabIndex = 2;
			this.dtpF_Solucion.Value = new System.DateTime(2015, 5, 24, 20, 26, 10, 0);
			// 
			// dtpF_Solcion
			// 
			this.dtpF_Solcion.AutoSize = true;
			this.dtpF_Solcion.Location = new System.Drawing.Point(2, 74);
			this.dtpF_Solcion.Name = "dtpF_Solcion";
			this.dtpF_Solcion.Size = new System.Drawing.Size(115, 19);
			this.dtpF_Solcion.TabIndex = 4;
			this.dtpF_Solcion.Text = "Fecha de Solucion";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(1, 14);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Material";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(3, 36);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(284, 29);
			this.txtDescripcion.TabIndex = 1;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(33, 347);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(21, 19);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 156;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// mdlSolucionarMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 373);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdlSolucionarMaterial";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Solucionar Material";
			this.Load += new System.EventHandler(this.mdlSolucionarMaterial_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroLabel dtpF_Solcion;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtObervacion;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.DateTimePicker dtpF_Solucion;
		private MetroFramework.Controls.MetroButton btnSalir;
		private MetroFramework.Controls.MetroButton btngGuardar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
	}
}