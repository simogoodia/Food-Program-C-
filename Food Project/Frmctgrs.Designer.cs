namespace Food_Project
{
    partial class Frmctgrs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbxCtgr = new System.Windows.Forms.TextBox();
            this.lblCtgr = new System.Windows.Forms.Label();
            this.tbxNameCtgr = new System.Windows.Forms.TextBox();
            this.lblNameCtgr = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelCtgr = new System.Windows.Forms.Button();
            this.btnAddCtgr = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCloseCtgrs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.Location = new System.Drawing.Point(1042, -2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(36, 32);
            this.BtnMin.TabIndex = 35;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(1076, -2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 32);
            this.BtnClose.TabIndex = 33;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbxCtgr
            // 
            this.lbxCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCtgr.Location = new System.Drawing.Point(379, 71);
            this.lbxCtgr.Name = "lbxCtgr";
            this.lbxCtgr.ReadOnly = true;
            this.lbxCtgr.Size = new System.Drawing.Size(605, 29);
            this.lbxCtgr.TabIndex = 4;
            // 
            // lblCtgr
            // 
            this.lblCtgr.AutoSize = true;
            this.lblCtgr.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtgr.Location = new System.Drawing.Point(1024, 70);
            this.lblCtgr.Name = "lblCtgr";
            this.lblCtgr.Size = new System.Drawing.Size(79, 27);
            this.lblCtgr.TabIndex = 3;
            this.lblCtgr.Text = "التصنيفات:";
            // 
            // tbxNameCtgr
            // 
            this.tbxNameCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameCtgr.Location = new System.Drawing.Point(379, 117);
            this.tbxNameCtgr.Name = "tbxNameCtgr";
            this.tbxNameCtgr.Size = new System.Drawing.Size(605, 29);
            this.tbxNameCtgr.TabIndex = 6;
            this.tbxNameCtgr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNameCtgr_KeyDown);
            // 
            // lblNameCtgr
            // 
            this.lblNameCtgr.AutoSize = true;
            this.lblNameCtgr.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCtgr.Location = new System.Drawing.Point(1007, 117);
            this.lblNameCtgr.Name = "lblNameCtgr";
            this.lblNameCtgr.Size = new System.Drawing.Size(96, 27);
            this.lblNameCtgr.TabIndex = 5;
            this.lblNameCtgr.Text = "اسم التصنيف:";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(258, 71);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 75);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "*جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.EnabledChanged += new System.EventHandler(this.btnNew_EnabledChanged);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelCtgr
            // 
            this.btnDelCtgr.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCtgr.Location = new System.Drawing.Point(12, 70);
            this.btnDelCtgr.Name = "btnDelCtgr";
            this.btnDelCtgr.Size = new System.Drawing.Size(102, 75);
            this.btnDelCtgr.TabIndex = 20;
            this.btnDelCtgr.Text = "حذف تصنيف";
            this.btnDelCtgr.UseVisualStyleBackColor = false;
            this.btnDelCtgr.EnabledChanged += new System.EventHandler(this.btnDelCtgr_EnabledChanged);
            this.btnDelCtgr.Click += new System.EventHandler(this.btnDelCtgr_Click);
            // 
            // btnAddCtgr
            // 
            this.btnAddCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCtgr.Location = new System.Drawing.Point(137, 70);
            this.btnAddCtgr.Name = "btnAddCtgr";
            this.btnAddCtgr.Size = new System.Drawing.Size(102, 75);
            this.btnAddCtgr.TabIndex = 21;
            this.btnAddCtgr.Text = "اضافة تصنيف";
            this.btnAddCtgr.UseVisualStyleBackColor = true;
            this.btnAddCtgr.EnabledChanged += new System.EventHandler(this.btnAddCtgr_EnabledChanged);
            this.btnAddCtgr.Click += new System.EventHandler(this.btnAddCtgr_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeight = 30;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(684, 184);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(397, 272);
            this.dgv.TabIndex = 22;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "categoryNo";
            this.Column1.HeaderText = "رقم التصنيف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "categoryName";
            this.Column2.HeaderText = "اسم التصنيف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 228;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Location = new System.Drawing.Point(473, 222);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(152, 75);
            this.btnAddAll.TabIndex = 23;
            this.btnAddAll.Text = "اضافة الكل";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.Location = new System.Drawing.Point(473, 315);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(152, 75);
            this.btnDelAll.TabIndex = 24;
            this.btnDelAll.Text = "الغاء الكل";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(37, 184);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(397, 277);
            this.lbx.TabIndex = 25;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(571, 469);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 75);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCloseCtgrs
            // 
            this.btnCloseCtgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCtgrs.Location = new System.Drawing.Point(379, 469);
            this.btnCloseCtgrs.Name = "btnCloseCtgrs";
            this.btnCloseCtgrs.Size = new System.Drawing.Size(152, 75);
            this.btnCloseCtgrs.TabIndex = 27;
            this.btnCloseCtgrs.Text = "اغلاق";
            this.btnCloseCtgrs.UseVisualStyleBackColor = true;
            this.btnCloseCtgrs.Click += new System.EventHandler(this.btnCloseCtgrs_Click);
            // 
            // Frmctgrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 556);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseCtgrs);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAddCtgr);
            this.Controls.Add(this.btnDelCtgr);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbxNameCtgr);
            this.Controls.Add(this.lblNameCtgr);
            this.Controls.Add(this.lbxCtgr);
            this.Controls.Add(this.lblCtgr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmctgrs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frmctgrs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lbxCtgr;
        private System.Windows.Forms.Label lblCtgr;
        private System.Windows.Forms.TextBox tbxNameCtgr;
        private System.Windows.Forms.Label lblNameCtgr;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelCtgr;
        private System.Windows.Forms.Button btnAddCtgr;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCloseCtgrs;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox lbx;
    }
}