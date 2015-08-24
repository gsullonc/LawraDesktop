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
			this.listaMaterialesOfAulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGeneral = new LawrApp.DataGeneral();
			this.tMaterialSalonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.listaMaterialesOfAulaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tMaterialSalonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.tMaterialSalonBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "LawrApp.Layouts.Reportes.Informes.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(20, 60);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.Size = new System.Drawing.Size(560, 520);
			this.reportViewer1.TabIndex = 0;
			// 
			// listaMaterialesOfAulaBindingSource
			// 
			this.listaMaterialesOfAulaBindingSource.DataMember = "ListaMaterialesOfAula";
			this.listaMaterialesOfAulaBindingSource.DataSource = this.dataGeneral;
			// 
			// dataGeneral
			// 
			this.dataGeneral.DataSetName = "DataGeneral";
			this.dataGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tMaterialSalonBindingSource
			// 
			this.tMaterialSalonBindingSource.DataSource = typeof(Objects.Tables.tMaterialSalon);
			// 
			// rptMaterialesOfAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.reportViewer1);
			this.Name = "rptMaterialesOfAula";
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Materiales";
			this.Load += new System.EventHandler(this.rptMaterialesOfAula_Load);
			((System.ComponentModel.ISupportInitialize)(this.listaMaterialesOfAulaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tMaterialSalonBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private DataGeneral dataGeneral;
		private System.Windows.Forms.BindingSource listaMaterialesOfAulaBindingSource;
		private System.Windows.Forms.BindingSource tMaterialSalonBindingSource;
	}
}