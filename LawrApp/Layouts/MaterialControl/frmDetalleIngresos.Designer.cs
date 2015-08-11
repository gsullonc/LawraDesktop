namespace LawrApp.Layouts.MaterialControl
{
	partial class frmDetalleIngresos
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
			this.btnModificar = new MetroFramework.Controls.MetroButton();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
			this.txtFechaIngreso = new System.Windows.Forms.TextBox();
			this.txtTipoIngreso = new System.Windows.Forms.TextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.lblEdad = new MetroFramework.Controls.MetroLabel();
			this.lblFecha_Nacimiento = new MetroFramework.Controls.MetroLabel();
			this.lblSexo = new MetroFramework.Controls.MetroLabel();
			this.lblnombres = new MetroFramework.Controls.MetroLabel();
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.toolTipValidacion = new System.Windows.Forms.ToolTip(this.components);
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.nudCantidad);
			this.panelMain.Controls.Add(this.btnModificar);
			this.panelMain.Controls.Add(this.txtCosto);
			this.panelMain.Controls.Add(this.txtNumeroDocumento);
			this.panelMain.Controls.Add(this.txtFechaIngreso);
			this.panelMain.Controls.Add(this.txtTipoIngreso);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.lblEdad);
			this.panelMain.Controls.Add(this.lblFecha_Nacimiento);
			this.panelMain.Controls.Add(this.lblSexo);
			this.panelMain.Controls.Add(this.lblnombres);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(421, 262);
			this.panelMain.TabIndex = 0;
			// 
			// btnModificar
			// 
			this.btnModificar.Enabled = false;
			this.btnModificar.Location = new System.Drawing.Point(332, 212);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 37);
			this.btnModificar.TabIndex = 171;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseSelectable = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(194, 103);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(223, 29);
			this.txtCosto.TabIndex = 170;
			this.txtCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoIngreso_KeyDown);
			// 
			// txtNumeroDocumento
			// 
			this.txtNumeroDocumento.Location = new System.Drawing.Point(5, 164);
			this.txtNumeroDocumento.Name = "txtNumeroDocumento";
			this.txtNumeroDocumento.Size = new System.Drawing.Size(412, 29);
			this.txtNumeroDocumento.TabIndex = 169;
			this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoIngreso_KeyDown);
			// 
			// txtFechaIngreso
			// 
			this.txtFechaIngreso.Location = new System.Drawing.Point(194, 40);
			this.txtFechaIngreso.Name = "txtFechaIngreso";
			this.txtFechaIngreso.Size = new System.Drawing.Size(223, 29);
			this.txtFechaIngreso.TabIndex = 167;
			this.txtFechaIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoIngreso_KeyDown);
			// 
			// txtTipoIngreso
			// 
			this.txtTipoIngreso.Location = new System.Drawing.Point(5, 40);
			this.txtTipoIngreso.Name = "txtTipoIngreso";
			this.txtTipoIngreso.Size = new System.Drawing.Size(183, 29);
			this.txtTipoIngreso.TabIndex = 166;
			this.txtTipoIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoIngreso_KeyDown);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.White;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel3.Location = new System.Drawing.Point(195, 22);
			this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(80, 15);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
			this.metroLabel3.TabIndex = 165;
			this.metroLabel3.Text = "Fecha Ingreso";
			this.metroLabel3.UseCustomForeColor = true;
			this.metroLabel3.UseStyleColors = true;
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblEdad.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblEdad.Location = new System.Drawing.Point(195, 85);
			this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(38, 15);
			this.lblEdad.Style = MetroFramework.MetroColorStyle.Black;
			this.lblEdad.TabIndex = 158;
			this.lblEdad.Text = "Costo";
			this.lblEdad.UseCustomForeColor = true;
			// 
			// lblFecha_Nacimiento
			// 
			this.lblFecha_Nacimiento.AutoSize = true;
			this.lblFecha_Nacimiento.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblFecha_Nacimiento.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblFecha_Nacimiento.Location = new System.Drawing.Point(5, 85);
			this.lblFecha_Nacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFecha_Nacimiento.Name = "lblFecha_Nacimiento";
			this.lblFecha_Nacimiento.Size = new System.Drawing.Size(55, 15);
			this.lblFecha_Nacimiento.Style = MetroFramework.MetroColorStyle.Black;
			this.lblFecha_Nacimiento.TabIndex = 157;
			this.lblFecha_Nacimiento.Text = "Cantidad";
			this.lblFecha_Nacimiento.UseCustomForeColor = true;
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblSexo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblSexo.Location = new System.Drawing.Point(5, 146);
			this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(117, 15);
			this.lblSexo.Style = MetroFramework.MetroColorStyle.Black;
			this.lblSexo.TabIndex = 156;
			this.lblSexo.Text = "Numero Documento";
			this.lblSexo.UseCustomForeColor = true;
			// 
			// lblnombres
			// 
			this.lblnombres.AutoSize = true;
			this.lblnombres.BackColor = System.Drawing.Color.White;
			this.lblnombres.FontSize = MetroFramework.MetroLabelSize.Small;
			this.lblnombres.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lblnombres.Location = new System.Drawing.Point(5, 22);
			this.lblnombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblnombres.Name = "lblnombres";
			this.lblnombres.Size = new System.Drawing.Size(82, 15);
			this.lblnombres.Style = MetroFramework.MetroColorStyle.Black;
			this.lblnombres.TabIndex = 155;
			this.lblnombres.Text = "Tipo Ingreso : ";
			this.lblnombres.UseCustomForeColor = true;
			this.lblnombres.UseStyleColors = true;
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(30, 338);
			this.pgsLoad.Maximum = 100;
			this.pgsLoad.Name = "pgsLoad";
			this.pgsLoad.Size = new System.Drawing.Size(18, 18);
			this.pgsLoad.Speed = 2F;
			this.pgsLoad.Style = MetroFramework.MetroColorStyle.Green;
			this.pgsLoad.TabIndex = 154;
			this.pgsLoad.UseSelectable = true;
			this.pgsLoad.Value = 50;
			this.pgsLoad.Visible = false;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(5, 104);
			this.nudCantidad.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(183, 29);
			this.nudCantidad.TabIndex = 172;
			// 
			// frmDetalleIngresos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 364);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmDetalleIngresos";
			this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Detalle del Ingreso de un Material ";
			this.Load += new System.EventHandler(this.frmDetalleIngresos_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel lblEdad;
		private MetroFramework.Controls.MetroLabel lblFecha_Nacimiento;
		private MetroFramework.Controls.MetroLabel lblSexo;
		private MetroFramework.Controls.MetroLabel lblnombres;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.TextBox txtNumeroDocumento;
		private System.Windows.Forms.TextBox txtFechaIngreso;
		private System.Windows.Forms.TextBox txtTipoIngreso;
		private MetroFramework.Controls.MetroButton btnModificar;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.ToolTip toolTipValidacion;
	}
}