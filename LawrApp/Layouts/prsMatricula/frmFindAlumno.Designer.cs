﻿namespace LawrApp.Layouts.prsMatricula
{
	partial class frmFindAlumno
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMain = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSiguiente = new MetroFramework.Controls.MetroButton();
			this.btnpreview = new MetroFramework.Controls.MetroButton();
			this.txtsearch = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.dgvalumnos = new System.Windows.Forms.DataGridView();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.dgvalumnos);
			this.panelMain.Controls.Add(this.label1);
			this.panelMain.Controls.Add(this.btnSiguiente);
			this.panelMain.Controls.Add(this.btnpreview);
			this.panelMain.Controls.Add(this.txtsearch);
			this.panelMain.Controls.Add(this.metroButton1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(27, 92);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(746, 477);
			this.panelMain.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Buscar: ";
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Location = new System.Drawing.Point(658, 439);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(85, 35);
			this.btnSiguiente.TabIndex = 17;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseSelectable = true;
			// 
			// btnpreview
			// 
			this.btnpreview.Location = new System.Drawing.Point(567, 439);
			this.btnpreview.Name = "btnpreview";
			this.btnpreview.Size = new System.Drawing.Size(85, 35);
			this.btnpreview.TabIndex = 16;
			this.btnpreview.Text = "Volver";
			this.btnpreview.UseSelectable = true;
			this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtsearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
			this.txtsearch.Lines = new string[0];
			this.txtsearch.Location = new System.Drawing.Point(71, 3);
			this.txtsearch.MaxLength = 32767;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.PasswordChar = '\0';
			this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtsearch.SelectedText = "";
			this.txtsearch.Size = new System.Drawing.Size(581, 30);
			this.txtsearch.TabIndex = 15;
			this.txtsearch.UseSelectable = true;
			this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(658, 3);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(85, 30);
			this.metroButton1.TabIndex = 13;
			this.metroButton1.Text = "Buscar";
			this.metroButton1.UseSelectable = true;
			// 
			// dgvalumnos
			// 
			this.dgvalumnos.AllowUserToAddRows = false;
			this.dgvalumnos.AllowUserToDeleteRows = false;
			this.dgvalumnos.AllowUserToResizeColumns = false;
			this.dgvalumnos.AllowUserToResizeRows = false;
			this.dgvalumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvalumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dgvalumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvalumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvalumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvalumnos.Location = new System.Drawing.Point(3, 39);
			this.dgvalumnos.MultiSelect = false;
			this.dgvalumnos.Name = "dgvalumnos";
			this.dgvalumnos.ReadOnly = true;
			this.dgvalumnos.RowHeadersVisible = false;
			this.dgvalumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvalumnos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.dgvalumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvalumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvalumnos.RowTemplate.Height = 28;
			this.dgvalumnos.RowTemplate.ReadOnly = true;
			this.dgvalumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvalumnos.ShowCellErrors = false;
			this.dgvalumnos.ShowCellToolTips = false;
			this.dgvalumnos.ShowEditingIcon = false;
			this.dgvalumnos.ShowRowErrors = false;
			this.dgvalumnos.Size = new System.Drawing.Size(740, 394);
			this.dgvalumnos.StandardTab = true;
			this.dgvalumnos.TabIndex = 19;
			// 
			// frmFindAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "frmFindAlumno";
			this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Buscar Alumno";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindAlumno_FormClosing);
			this.Load += new System.EventHandler(this.frmFindAlumno_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroButton btnSiguiente;
		private MetroFramework.Controls.MetroButton btnpreview;
		private MetroFramework.Controls.MetroTextBox txtsearch;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.DataGridView dgvalumnos;
	}
}