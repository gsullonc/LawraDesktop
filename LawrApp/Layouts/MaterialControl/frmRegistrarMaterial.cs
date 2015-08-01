using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace LawrApp.Layouts.MaterialControl
{
	public partial class frmRegistrarMaterial : MetroForm
	{
		public frmRegistrarMaterial()
		{
			InitializeComponent();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			this.tabpageMain.SelectedTab = this.tabpagRegistro;
			this.panelRegister.Enabled   = true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.panelRegister.Enabled   = false;
			this.tabpageMain.SelectedTab = this.tabpagMaterial;
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			mdlSearch search = new mdlSearch();
			search.ShowDialog();
		}
	}
}
