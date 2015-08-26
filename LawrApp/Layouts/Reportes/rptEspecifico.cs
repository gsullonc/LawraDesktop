using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace LawrApp.Layouts.Reportes
{
	public partial class rptEspecifico : MetroForm
	{
		DataGeneral _data;
		public rptEspecifico(DataGeneral dts)
		{
			_data = dts; 
			InitializeComponent();
		}

		private void rptEspecifico_Load(object sender, EventArgs e)
		{
			ReportDataSource rds = new ReportDataSource("Gastos", _data.Tables["Gastos"]);
			ReportDataSource rds1 = new ReportDataSource("Conteo", _data.Tables["ConteoPorEstado"]);
			ReportDataSource rds2 = new ReportDataSource("Materiales", _data.Tables["ListaMaterialesOfAula"]);

			this.rptInformeEstado.LocalReport.DataSources.Clear();

			this.rptInformeEstado.PromptAreaCollapsed = true;
			this.rptInformeEstado.SetDisplayMode(DisplayMode.PrintLayout);
			this.rptInformeEstado.LocalReport.DataSources.Add(rds);
			this.rptInformeEstado.LocalReport.DataSources.Add(rds1);
			this.rptInformeEstado.LocalReport.DataSources.Add(rds2);
			this.rptInformeEstado.RefreshReport();
			this.rptInformeEstado.Refresh();
		}
	}
}
