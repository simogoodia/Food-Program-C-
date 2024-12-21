namespace Food_Project
{
    partial class suggestFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFoodName = new System.Windows.Forms.TextBox();
            this.lblCtgrs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxComs = new System.Windows.Forms.TextBox();
            this.tbxCtgrs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "اسم الاكلة:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxFoodName.Location = new System.Drawing.Point(109, 73);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(763, 27);
            this.tbxFoodName.TabIndex = 37;
            this.tbxFoodName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCtgrs
            // 
            this.lblCtgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblCtgrs.Location = new System.Drawing.Point(12, 118);
            this.lblCtgrs.Name = "lblCtgrs";
            this.lblCtgrs.Size = new System.Drawing.Size(102, 27);
            this.lblCtgrs.TabIndex = 38;
            this.lblCtgrs.Text = "التصنيفات:";
            this.lblCtgrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "التصنيفات:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(12, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "التصنيفات:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(980, 70);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(118, 106);
            this.img.TabIndex = 44;
            this.img.TabStop = false;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxDesc.Location = new System.Drawing.Point(109, 375);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(763, 105);
            this.tbxDesc.TabIndex = 47;
            // 
            // tbxComs
            // 
            this.tbxComs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxComs.Location = new System.Drawing.Point(109, 243);
            this.tbxComs.Multiline = true;
            this.tbxComs.Name = "tbxComs";
            this.tbxComs.Size = new System.Drawing.Size(763, 105);
            this.tbxComs.TabIndex = 48;
            // 
            // tbxCtgrs
            // 
            this.tbxCtgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxCtgrs.Location = new System.Drawing.Point(109, 115);
            this.tbxCtgrs.Multiline = true;
            this.tbxCtgrs.Name = "tbxCtgrs";
            this.tbxCtgrs.Size = new System.Drawing.Size(763, 105);
            this.tbxCtgrs.TabIndex = 49;
            // 
            // suggestFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 556);
            this.Controls.Add(this.tbxCtgrs);
            this.Controls.Add(this.tbxComs);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCtgrs);
            this.Controls.Add(this.tbxFoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "suggestFood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suggestFood";
            this.Load += new System.EventHandler(this.suggestFood_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCtgrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxFoodName;
        public System.Windows.Forms.PictureBox img;
        public System.Windows.Forms.TextBox tbxDesc;
        public System.Windows.Forms.TextBox tbxComs;
        public System.Windows.Forms.TextBox tbxCtgrs;
    }
}