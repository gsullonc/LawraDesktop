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
			this.panel1 = new System.Windows.Forms.Panel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.dtpF_Solcion = new MetroFramework.Controls.MetroLabel();
			this.dtpF_Solucion = new System.Windows.Forms.DateTimePicker();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtObervacion = new System.Windows.Forms.TextBox();
			this.btnSalir = new MetroFramework.Controls.MetroButton();
			this.btngGuardar = new MetroFramework.Controls.MetroButton();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.btngGuardar);
			this.panel1.Controls.Add(this.txtObervacion);
			this.panel1.Controls.Add(this.metroLabel2);
			this.panel1.Controls.Add(this.dtpF_Solucion);
			this.panel1.Controls.Add(this.dtpF_Solcion);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Controls.Add(this.txtDescripcion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(30, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 271);
			this.panel1.TabIndex = 0;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(15, 20);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Material";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(19, 42);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(252, 29);
			this.txtDescripcion.TabIndex = 1;
			// 
			// dtpF_Solcion
			// 
			this.dtpF_Solcion.AutoSize = true;
			this.dtpF_Solcion.Location = new System.Drawing.Point(15, 83);
			this.dtpF_Solcion.Name = "dtpF_Solcion";
			this.dtpF_Solcion.Size = new System.Drawing.Size(115, 19);
			this.dtpF_Solcion.TabIndex = 4;
			this.dtpF_Solcion.Text = "Fecha de Solucion";
			// 
			// dtpF_Solucion
			// 
			this.dtpF_Solucion.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpF_Solucion.CustomFormat = "yyyy-MM-dd";
			this.dtpF_Solucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpF_Solucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpF_Solucion.Location = new System.Drawing.Point(19, 105);
			this.dtpF_Solucion.Name = "dtpF_Solucion";
			this.dtpF_Solucion.Size = new System.Drawing.Size(252, 29);
			this.dtpF_Solucion.TabIndex = 2;
			this.dtpF_Solucion.Value = new System.DateTime(2015, 5, 24, 20, 26, 10, 0);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(15, 150);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(83, 19);
			this.metroLabel2.TabIndex = 40;
			this.metroLabel2.Text = "Observacion";
			// 
			// txtObervacion
			// 
			this.txtObervacion.Location = new System.Drawing.Point(19, 172);
			this.txtObervacion.Name = "txtObervacion";
			this.txtObervacion.Size = new System.Drawing.Size(252, 29);
			this.txtObervacion.TabIndex = 3;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(115, 218);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseSelectable = true;
			// 
			// btngGuardar
			// 
			this.btngGuardar.Location = new System.Drawing.Point(196, 218);
			this.btngGuardar.Name = "btngGuardar";
			this.btngGuardar.Size = new System.Drawing.Size(75, 31);
			this.btngGuardar.TabIndex = 4;
			this.btngGuardar.Text = "Guardar";
			this.btngGuardar.UseSelectable = true;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(49, 374);
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
			this.ClientSize = new System.Drawing.Size(350, 400);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "mdlSolucionarMaterial";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Solucionar Material";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
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