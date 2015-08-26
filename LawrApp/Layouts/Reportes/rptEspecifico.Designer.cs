namespace LawrApp.Layouts.Reportes
{
	partial class rptEspecifico
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rptInformeEstado = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dataGeneral = new LawrApp.DataGeneral();
			this.GastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GastosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rptInformeEstado);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 510);
			this.panel1.TabIndex = 0;
			// 
			// rptInformeEstado
			// 
			this.rptInformeEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rptInformeEstado.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "Gastos";
			reportDataSource1.Value = this.GastosBindingSource;
			this.rptInformeEstado.LocalReport.DataSources.Add(reportDataSource1);
			this.rptInformeEstado.LocalReport.ReportEmbeddedResource = "LawrApp.Layouts.Reportes.Informes.rptEspecifico.rdlc";
			this.rptInformeEstado.Location = new System.Drawing.Point(0, 0);
			this.rptInformeEstado.Name = "rptInformeEstado";
			this.rptInformeEstado.Size = new System.Drawing.Size(800, 510);
			this.rptInformeEstado.TabIndex = 0;
			this.rptInformeEstado.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
			// 
			// dataGeneral
			// 
			this.dataGeneral.DataSetName = "DataGeneral";
			this.dataGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// GastosBindingSource
			// 
			this.GastosBindingSource.DataMember = "Gastos";
			this.GastosBindingSource.DataSource = this.dataGeneral;
			// 
			// rptEspecifico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panel1);
			this.Name = "rptEspecifico";
			this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 20);
			this.Text = "Informe de Materiales por Estado";
			this.Load += new System.EventHandler(this.rptEspecifico_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GastosBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Microsoft.Reporting.WinForms.ReportViewer rptInformeEstado;
		private DataGeneral dataGeneral;
		private System.Windows.Forms.BindingSource GastosBindingSource;
	}
}