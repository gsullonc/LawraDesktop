namespace LawrApp.Layouts.Reportes
{
	partial class rptMaterialesOfAula
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dataGeneral = new LawrApp.DataGeneral();
			this.ListaMaterialesOfAulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ListaMaterialesOfAulaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "MaterialesOfAula";
			reportDataSource1.Value = this.ListaMaterialesOfAulaBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "LawrApp.Layouts.Reportes.Informes.MaterialesEnAula.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 60);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.Size = new System.Drawing.Size(800, 520);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
			// 
			// dataGeneral
			// 
			this.dataGeneral.DataSetName = "DataGeneral";
			this.dataGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ListaMaterialesOfAulaBindingSource
			// 
			this.ListaMaterialesOfAulaBindingSource.DataMember = "ListaMaterialesOfAula";
			this.ListaMaterialesOfAulaBindingSource.DataSource = this.dataGeneral;
			// 
			// rptMaterialesOfAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.reportViewer1);
			this.Name = "rptMaterialesOfAula";
			this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 20);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.Default;
			this.Text = "Materiales";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.rptMaterialesOfAula_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ListaMaterialesOfAulaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private DataGeneral dataGeneral;
		private System.Windows.Forms.BindingSource ListaMaterialesOfAulaBindingSource;
	}
}