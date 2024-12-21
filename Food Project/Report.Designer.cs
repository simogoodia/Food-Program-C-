namespace Food_Project
{
    partial class Report
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
            this.foodBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Food_Project.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foodBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // foodBindingSource2
            // 
            this.foodBindingSource2.DataMember = "food";
            this.foodBindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnMax);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.Location = new System.Drawing.Point(1011, -1);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(36, 32);
            this.BtnMin.TabIndex = 34;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMax.Location = new System.Drawing.Point(1044, -1);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(36, 32);
            this.BtnMax.TabIndex = 33;
            this.BtnMax.Text = "ّ";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(1076, -1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 32);
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.foodBindingSource2;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Food_Project.Report.rdlc";
            this.rv.Location = new System.Drawing.Point(3, 33);
            this.rv.Name = "rv";
            this.rv.ServerReport.BearerToken = null;
            this.rv.Size = new System.Drawing.Size(1103, 521);
            this.rv.TabIndex = 3;
            this.rv.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "food";
            this.foodBindingSource.DataSource = this.dataSet1;
            // 
            // foodBindingSource1
            // 
            this.foodBindingSource1.DataMember = "food";
            this.foodBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // foodBindingSource3
            // 
            this.foodBindingSource3.DataMember = "food";
            this.foodBindingSource3.DataSource = this.dataSet1BindingSource;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 556);
            this.ControlBox = false;
            this.Controls.Add(this.rv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.BindingSource foodBindingSource1;
        private System.Windows.Forms.BindingSource foodBindingSource2;
        public Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource foodBindingSource3;
    }
}