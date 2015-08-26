using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using LawrApp.Layouts.Reportes;
using Microsoft.Reporting.WinForms;

namespace LawrApp.Layouts.Reportes
{
	public partial class rptMaterialesOfAula : MetroForm
	{
		DataGeneral _data;
		public rptMaterialesOfAula(DataGeneral dts)
		{
			_data = dts;
			InitializeComponent();
		}

		private void rptMaterialesOfAula_Load(object sender, EventArgs e)
		{
			ReportDataSource rds = new ReportDataSource("MaterialesOfAula", _data.Tables["ListaMaterialesOfAula"]);
			reportViewer1.LocalReport.DataSources.Clear();

			this.reportViewer1.PromptAreaCollapsed = true;
			this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

			reportViewer1.LocalReport.DataSources.Add(rds);
			reportViewer1.RefreshReport();
			reportViewer1.Refresh();
		}
	}
}
