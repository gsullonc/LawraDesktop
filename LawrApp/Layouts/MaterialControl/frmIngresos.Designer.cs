namespace LawrApp.Layouts.MaterialControl
{
	partial class frmIngresos
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
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblValidateCosto = new System.Windows.Forms.Label();
			this.lblValidateNº_Documento = new System.Windows.Forms.Label();
			this.lblValidateFecha_Compra = new System.Windows.Forms.Label();
			this.lblValidateCantidad = new System.Windows.Forms.Label();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.dtpFecha_Compra = new System.Windows.Forms.DateTimePicker();
			this.lblValidateTipoIngreso = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.btnsalir = new MetroFramework.Controls.MetroButton();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.txtNªDocumento = new System.Windows.Forms.TextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.cboTipoIngreso = new System.Windows.Forms.ComboBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.btnbuscar = new MetroFramework.Controls.MetroButton();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.toltipValid = new System.Windows.Forms.ToolTip(this.components);
			this.pgsLoad = new MetroFramework.Controls.MetroProgressSpinner();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.nudCantidad);
			this.panelMain.Controls.Add(this.lblValidateCosto);
			this.panelMain.Controls.Add(this.lblValidateNº_Documento);
			this.panelMain.Controls.Add(this.lblValidateFecha_Compra);
			this.panelMain.Controls.Add(this.lblValidateCantidad);
			this.panelMain.Controls.Add(this.metroLabel9);
			this.panelMain.Controls.Add(this.dtpFecha_Compra);
			this.panelMain.Controls.Add(this.lblValidateTipoIngreso);
			this.panelMain.Controls.Add(this.txtMarca);
			this.panelMain.Controls.Add(this.btnsalir);
			this.panelMain.Controls.Add(this.btnGuardar);
			this.panelMain.Controls.Add(this.metroLabel8);
			this.panelMain.Controls.Add(this.txtNªDocumento);
			this.panelMain.Controls.Add(this.metroLabel7);
			this.panelMain.Controls.Add(this.txtCosto);
			this.panelMain.Controls.Add(this.metroLabel6);
			this.panelMain.Controls.Add(this.cboTipoIngreso);
			this.panelMain.Controls.Add(this.metroLabel5);
			this.panelMain.Controls.Add(this.txtModelo);
			this.panelMain.Controls.Add(this.metroLabel4);
			this.panelMain.Controls.Add(this.metroLabel3);
			this.panelMain.Controls.Add(this.txtCategoria);
			this.panelMain.Controls.Add(this.metroLabel2);
			this.panelMain.Controls.Add(this.btnbuscar);
			this.panelMain.Controls.Add(this.txtDescripcion);
			this.panelMain.Controls.Add(this.metroLabel1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(30, 97);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(590, 301);
			this.panelMain.TabIndex = 0;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Enabled = false;
			this.nudCantidad.Location = new System.Drawing.Point(3, 227);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(195, 29);
			this.nudCantidad.TabIndex = 63;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged_1);
			this.nudCantidad.Leave += new System.EventHandler(this.nudCantidad_Leave);
			// 
			// lblValidateCosto
			// 
			this.lblValidateCosto.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCosto.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCosto.Location = new System.Drawing.Point(461, 150);
			this.lblValidateCosto.Name = "lblValidateCosto";
			this.lblValidateCosto.Size = new System.Drawing.Size(24, 16);
			this.lblValidateCosto.TabIndex = 62;
			this.lblValidateCosto.Text = "*";
			this.lblValidateCosto.Visible = false;
			// 
			// lblValidateNº_Documento
			// 
			this.lblValidateNº_Documento.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateNº_Documento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateNº_Documento.ForeColor = System.Drawing.Color.Red;
			this.lblValidateNº_Documento.Location = new System.Drawing.Point(307, 207);
			this.lblValidateNº_Documento.Name = "lblValidateNº_Documento";
			this.lblValidateNº_Documento.Size = new System.Drawing.Size(24, 16);
			this.lblValidateNº_Documento.TabIndex = 61;
			this.lblValidateNº_Documento.Text = "*";
			this.lblValidateNº_Documento.Visible = false;
			// 
			// lblValidateFecha_Compra
			// 
			this.lblValidateFecha_Compra.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateFecha_Compra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateFecha_Compra.ForeColor = System.Drawing.Color.Red;
			this.lblValidateFecha_Compra.Location = new System.Drawing.Point(325, 147);
			this.lblValidateFecha_Compra.Name = "lblValidateFecha_Compra";
			this.lblValidateFecha_Compra.Size = new System.Drawing.Size(24, 16);
			this.lblValidateFecha_Compra.TabIndex = 60;
			this.lblValidateFecha_Compra.Text = "*";
			this.lblValidateFecha_Compra.Visible = false;
			// 
			// lblValidateCantidad
			// 
			this.lblValidateCantidad.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateCantidad.ForeColor = System.Drawing.Color.Red;
			this.lblValidateCantidad.Location = new System.Drawing.Point(71, 207);
			this.lblValidateCantidad.Name = "lblValidateCantidad";
			this.lblValidateCantidad.Size = new System.Drawing.Size(24, 16);
			this.lblValidateCantidad.TabIndex = 59;
			this.lblValidateCantidad.Text = "*";
			this.lblValidateCantidad.Visible = false;
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(204, 147);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(115, 19);
			this.metroLabel9.TabIndex = 58;
			this.metroLabel9.Text = "Fecha de Compra";
			// 
			// dtpFecha_Compra
			// 
			this.dtpFecha_Compra.CustomFormat = "yyyy-MM-dd";
			this.dtpFecha_Compra.Enabled = false;
			this.dtpFecha_Compra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha_Compra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecha_Compra.Location = new System.Drawing.Point(204, 166);
			this.dtpFecha_Compra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpFecha_Compra.Name = "dtpFecha_Compra";
			this.dtpFecha_Compra.Size = new System.Drawing.Size(202, 29);
			this.dtpFecha_Compra.TabIndex = 3;
			// 
			// lblValidateTipoIngreso
			// 
			this.lblValidateTipoIngreso.BackColor = System.Drawing.Color.Transparent;
			this.lblValidateTipoIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValidateTipoIngreso.ForeColor = System.Drawing.Color.Red;
			this.lblValidateTipoIngreso.Location = new System.Drawing.Point(91, 147);
			this.lblValidateTipoIngreso.Name = "lblValidateTipoIngreso";
			this.lblValidateTipoIngreso.Size = new System.Drawing.Size(24, 16);
			this.lblValidateTipoIngreso.TabIndex = 56;
			this.lblValidateTipoIngreso.Text = "*";
			// 
			// txtMarca
			// 
			this.txtMarca.Enabled = false;
			this.txtMarca.Location = new System.Drawing.Point(204, 107);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(202, 29);
			this.txtMarca.TabIndex = 27;
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(422, 267);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 31);
			this.btnsalir.TabIndex = 10;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseSelectable = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Location = new System.Drawing.Point(512, 267);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 31);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "Hecho";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(3, 204);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(62, 19);
			this.metroLabel8.TabIndex = 26;
			this.metroLabel8.Text = "Cantidad";
			// 
			// txtNªDocumento
			// 
			this.txtNªDocumento.Enabled = false;
			this.txtNªDocumento.Location = new System.Drawing.Point(204, 226);
			this.txtNªDocumento.Name = "txtNªDocumento";
			this.txtNªDocumento.Size = new System.Drawing.Size(383, 29);
			this.txtNªDocumento.TabIndex = 6;
			this.txtNªDocumento.TextChanged += new System.EventHandler(this.txtNªDocumento_TextChanged);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(204, 204);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(97, 19);
			this.metroLabel7.TabIndex = 24;
			this.metroLabel7.Text = "Nº Documento";
			// 
			// txtCosto
			// 
			this.txtCosto.Enabled = false;
			this.txtCosto.Location = new System.Drawing.Point(412, 166);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(175, 29);
			this.txtCosto.TabIndex = 4;
			this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
			this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(412, 147);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(43, 19);
			this.metroLabel6.TabIndex = 22;
			this.metroLabel6.Text = "Costo";
			// 
			// cboTipoIngreso
			// 
			this.cboTipoIngreso.Enabled = false;
			this.cboTipoIngreso.FormattingEnabled = true;
			this.cboTipoIngreso.Items.AddRange(new object[] {
            "Donacion\t",
            "Compra"});
			this.cboTipoIngreso.Location = new System.Drawing.Point(3, 166);
			this.cboTipoIngreso.Name = "cboTipoIngreso";
			this.cboTipoIngreso.Size = new System.Drawing.Size(195, 29);
			this.cboTipoIngreso.TabIndex = 2;
			this.cboTipoIngreso.SelectedIndexChanged += new System.EventHandler(this.cboTipoIngreso_SelectedIndexChanged);
			this.cboTipoIngreso.SelectionChangeCommitted += new System.EventHandler(this.cboTipoIngreso_SelectionChangeCommitted);
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(3, 144);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(82, 19);
			this.metroLabel5.TabIndex = 20;
			this.metroLabel5.Text = "Tipo Ingreso";
			// 
			// txtModelo
			// 
			this.txtModelo.Enabled = false;
			this.txtModelo.Location = new System.Drawing.Point(412, 107);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(175, 29);
			this.txtModelo.TabIndex = 5;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(412, 85);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(55, 19);
			this.metroLabel4.TabIndex = 7;
			this.metroLabel4.Text = "Modelo";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(204, 85);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(46, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Marca";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Enabled = false;
			this.txtCategoria.Location = new System.Drawing.Point(3, 107);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(195, 29);
			this.txtCategoria.TabIndex = 3;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(3, 85);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(67, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Categoria";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(512, 44);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(75, 29);
			this.btnbuscar.TabIndex = 1;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseSelectable = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(3, 44);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(503, 29);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(3, 22);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Material";
			// 
			// toltipValid
			// 
			this.toltipValid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toltipValid.ToolTipTitle = "Requerido";
			// 
			// pgsLoad
			// 
			this.pgsLoad.Location = new System.Drawing.Point(30, 404);
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
			// frmIngresos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 430);
			this.Controls.Add(this.pgsLoad);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmIngresos";
			this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Ingresos de Materiales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngresos_FormClosing);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TextBox txtModelo;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TextBox txtCategoria;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton btnbuscar;
		private System.Windows.Forms.TextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private System.Windows.Forms.TextBox txtNªDocumento;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private System.Windows.Forms.TextBox txtCosto;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.ComboBox cboTipoIngreso;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroButton btnsalir;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label lblValidateTipoIngreso;
		private System.Windows.Forms.ToolTip toltipValid;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		public System.Windows.Forms.DateTimePicker dtpFecha_Compra;
		private MetroFramework.Controls.MetroProgressSpinner pgsLoad;
		private System.Windows.Forms.Label lblValidateNº_Documento;
		private System.Windows.Forms.Label lblValidateFecha_Compra;
		private System.Windows.Forms.Label lblValidateCantidad;
		private System.Windows.Forms.Label lblValidateCosto;
		private System.Windows.Forms.NumericUpDown nudCantidad;
	}
}