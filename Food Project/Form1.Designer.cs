namespace Food_Project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxImg = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.tbxCtg = new System.Windows.Forms.TextBox();
            this.lblCtg = new System.Windows.Forms.Label();
            this.btnAddCtg = new System.Windows.Forms.Button();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.tbxCom = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.lbxCom = new System.Windows.Forms.ListBox();
            this.btnDelSlcCom = new System.Windows.Forms.Button();
            this.btnDelLastCom = new System.Windows.Forms.Button();
            this.btnDelAllCom = new System.Windows.Forms.Button();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tbxSuggestCtgr = new System.Windows.Forms.TextBox();
            this.btnSuggestFood = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.foodCtgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoCtgr = new System.Windows.Forms.RadioButton();
            this.rdoCom = new System.Windows.Forms.RadioButton();
            this.rdoDesc = new System.Windows.Forms.RadioButton();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbxFoodeName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnMax);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 30);
            this.panel1.TabIndex = 0;
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
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(12, 109);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(74, 27);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "اسم الاكلة:";
            // 
            // tbxCode
            // 
            this.tbxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.Location = new System.Drawing.Point(133, 76);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.ReadOnly = true;
            this.tbxCode.Size = new System.Drawing.Size(260, 29);
            this.tbxCode.TabIndex = 2;
            // 
            // tbxImg
            // 
            this.tbxImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImg.Location = new System.Drawing.Point(133, 145);
            this.tbxImg.Name = "tbxImg";
            this.tbxImg.Size = new System.Drawing.Size(172, 24);
            this.tbxImg.TabIndex = 4;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(12, 142);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(92, 27);
            this.lblImg.TabIndex = 3;
            this.lblImg.Text = "صورة الاكلة:";
            // 
            // btnAddImg
            // 
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.Location = new System.Drawing.Point(133, 174);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(172, 40);
            this.btnAddImg.TabIndex = 4;
            this.btnAddImg.Text = "اضافة الصورة";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(311, 142);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(82, 66);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 4;
            this.img.TabStop = false;
            // 
            // tbxCtg
            // 
            this.tbxCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCtg.Location = new System.Drawing.Point(133, 217);
            this.tbxCtg.Name = "tbxCtg";
            this.tbxCtg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxCtg.Size = new System.Drawing.Size(229, 29);
            this.tbxCtg.TabIndex = 6;
            this.tbxCtg.WordWrap = false;
            // 
            // lblCtg
            // 
            this.lblCtg.AutoSize = true;
            this.lblCtg.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtg.Location = new System.Drawing.Point(12, 217);
            this.lblCtg.Name = "lblCtg";
            this.lblCtg.Size = new System.Drawing.Size(108, 27);
            this.lblCtg.TabIndex = 5;
            this.lblCtg.Text = "تصنيفات الاكلة:";
            // 
            // btnAddCtg
            // 
            this.btnAddCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCtg.Location = new System.Drawing.Point(362, 218);
            this.btnAddCtg.Name = "btnAddCtg";
            this.btnAddCtg.Size = new System.Drawing.Size(31, 29);
            this.btnAddCtg.TabIndex = 4;
            this.btnAddCtg.Text = "+";
            this.btnAddCtg.UseVisualStyleBackColor = true;
            this.btnAddCtg.Click += new System.EventHandler(this.btnAddCtg_Click);
            // 
            // btnAddCom
            // 
            this.btnAddCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCom.Location = new System.Drawing.Point(362, 250);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(31, 29);
            this.btnAddCom.TabIndex = 7;
            this.btnAddCom.Text = "+";
            this.btnAddCom.UseVisualStyleBackColor = true;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // tbxCom
            // 
            this.tbxCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCom.Location = new System.Drawing.Point(133, 250);
            this.tbxCom.Name = "tbxCom";
            this.tbxCom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxCom.Size = new System.Drawing.Size(229, 29);
            this.tbxCom.TabIndex = 9;
            this.tbxCom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCom_KeyDown);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(12, 253);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(61, 27);
            this.lblCom.TabIndex = 8;
            this.lblCom.Text = "المقادير:";
            // 
            // lbxCom
            // 
            this.lbxCom.FormattingEnabled = true;
            this.lbxCom.Location = new System.Drawing.Point(133, 282);
            this.lbxCom.Name = "lbxCom";
            this.lbxCom.ScrollAlwaysVisible = true;
            this.lbxCom.Size = new System.Drawing.Size(260, 82);
            this.lbxCom.TabIndex = 10;
            // 
            // btnDelSlcCom
            // 
            this.btnDelSlcCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSlcCom.Location = new System.Drawing.Point(17, 286);
            this.btnDelSlcCom.Name = "btnDelSlcCom";
            this.btnDelSlcCom.Size = new System.Drawing.Size(102, 26);
            this.btnDelSlcCom.TabIndex = 11;
            this.btnDelSlcCom.Text = "حذف المحدد:";
            this.btnDelSlcCom.UseVisualStyleBackColor = true;
            this.btnDelSlcCom.Click += new System.EventHandler(this.btnDelSlcCom_Click);
            // 
            // btnDelLastCom
            // 
            this.btnDelLastCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLastCom.Location = new System.Drawing.Point(17, 311);
            this.btnDelLastCom.Name = "btnDelLastCom";
            this.btnDelLastCom.Size = new System.Drawing.Size(102, 26);
            this.btnDelLastCom.TabIndex = 12;
            this.btnDelLastCom.Text = "حذف اخر عنصر:";
            this.btnDelLastCom.UseVisualStyleBackColor = true;
            this.btnDelLastCom.Click += new System.EventHandler(this.btnDelLastCom_Click);
            // 
            // btnDelAllCom
            // 
            this.btnDelAllCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAllCom.Location = new System.Drawing.Point(17, 336);
            this.btnDelAllCom.Name = "btnDelAllCom";
            this.btnDelAllCom.Size = new System.Drawing.Size(102, 26);
            this.btnDelAllCom.TabIndex = 13;
            this.btnDelAllCom.Text = "حذف الكل:";
            this.btnDelAllCom.UseVisualStyleBackColor = true;
            this.btnDelAllCom.Click += new System.EventHandler(this.btnDelAllCom_Click);
            // 
            // tbxDesc
            // 
            this.tbxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesc.Location = new System.Drawing.Point(133, 367);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDesc.Size = new System.Drawing.Size(260, 78);
            this.tbxDesc.TabIndex = 15;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(12, 378);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(112, 27);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "طريقة التحضير:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.Control;
            this.lblText.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblText.Location = new System.Drawing.Point(13, 449);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblText.Size = new System.Drawing.Size(28, 22);
            this.lblText.TabIndex = 16;
            this.lblText.Text = ">>";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(22, 483);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 68);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "*جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(133, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 68);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(241, 483);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 68);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.Location = new System.Drawing.Point(349, 483);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 68);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(463, 483);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(102, 68);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "تقرير";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.Location = new System.Drawing.Point(571, 483);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(102, 68);
            this.btnClose2.TabIndex = 21;
            this.btnClose2.Text = "خروج";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(1057, 483);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(33, 29);
            this.button16.TabIndex = 22;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // tbxSuggestCtgr
            // 
            this.tbxSuggestCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSuggestCtgr.Location = new System.Drawing.Point(679, 483);
            this.tbxSuggestCtgr.Name = "tbxSuggestCtgr";
            this.tbxSuggestCtgr.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxSuggestCtgr.Size = new System.Drawing.Size(376, 29);
            this.tbxSuggestCtgr.TabIndex = 23;
            this.tbxSuggestCtgr.WordWrap = false;
            // 
            // btnSuggestFood
            // 
            this.btnSuggestFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuggestFood.Location = new System.Drawing.Point(679, 514);
            this.btnSuggestFood.Name = "btnSuggestFood";
            this.btnSuggestFood.Size = new System.Drawing.Size(411, 37);
            this.btnSuggestFood.TabIndex = 24;
            this.btnSuggestFood.Text = "اقتراح اكلة";
            this.btnSuggestFood.UseVisualStyleBackColor = true;
            this.btnSuggestFood.Click += new System.EventHandler(this.btnSuggestFood_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodName,
            this.foodImg,
            this.foodCtgr,
            this.foodCom,
            this.foodDesc,
            this.foodCode});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Location = new System.Drawing.Point(407, 112);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.Size = new System.Drawing.Size(698, 334);
            this.dgv.TabIndex = 25;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // foodName
            // 
            this.foodName.DataPropertyName = "foodName";
            this.foodName.HeaderText = "اسم الاكلة";
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            this.foodName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.foodName.Width = 125;
            // 
            // foodImg
            // 
            this.foodImg.DataPropertyName = "foodImg";
            this.foodImg.HeaderText = "صورة الاكلة";
            this.foodImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.foodImg.Name = "foodImg";
            this.foodImg.ReadOnly = true;
            this.foodImg.Width = 130;
            // 
            // foodCtgr
            // 
            this.foodCtgr.DataPropertyName = "categoryName";
            this.foodCtgr.HeaderText = "التصنيفات";
            this.foodCtgr.Name = "foodCtgr";
            this.foodCtgr.ReadOnly = true;
            this.foodCtgr.Width = 130;
            // 
            // foodCom
            // 
            this.foodCom.DataPropertyName = "foodCom";
            this.foodCom.HeaderText = "المقادير";
            this.foodCom.Name = "foodCom";
            this.foodCom.ReadOnly = true;
            this.foodCom.Width = 130;
            // 
            // foodDesc
            // 
            this.foodDesc.DataPropertyName = "foodDesc";
            this.foodDesc.HeaderText = "الوصف";
            this.foodDesc.Name = "foodDesc";
            this.foodDesc.ReadOnly = true;
            this.foodDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foodDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.foodDesc.Width = 140;
            // 
            // foodCode
            // 
            this.foodCode.DataPropertyName = "foodCode";
            this.foodCode.HeaderText = "كود الاكلة";
            this.foodCode.Name = "foodCode";
            this.foodCode.ReadOnly = true;
            this.foodCode.Visible = false;
            this.foodCode.Width = 30;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoName.Location = new System.Drawing.Point(654, 77);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(59, 26);
            this.rdoName.TabIndex = 4;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "الاسم";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoCtgr
            // 
            this.rdoCtgr.AutoSize = true;
            this.rdoCtgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCtgr.Location = new System.Drawing.Point(571, 76);
            this.rdoCtgr.Name = "rdoCtgr";
            this.rdoCtgr.Size = new System.Drawing.Size(77, 26);
            this.rdoCtgr.TabIndex = 26;
            this.rdoCtgr.TabStop = true;
            this.rdoCtgr.Text = "التصنيف";
            this.rdoCtgr.UseVisualStyleBackColor = true;
            // 
            // rdoCom
            // 
            this.rdoCom.AutoSize = true;
            this.rdoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCom.Location = new System.Drawing.Point(494, 76);
            this.rdoCom.Name = "rdoCom";
            this.rdoCom.Size = new System.Drawing.Size(71, 26);
            this.rdoCom.TabIndex = 27;
            this.rdoCom.TabStop = true;
            this.rdoCom.Text = "المقادير";
            this.rdoCom.UseVisualStyleBackColor = true;
            // 
            // rdoDesc
            // 
            this.rdoDesc.AutoSize = true;
            this.rdoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDesc.Location = new System.Drawing.Point(410, 76);
            this.rdoDesc.Name = "rdoDesc";
            this.rdoDesc.Size = new System.Drawing.Size(78, 26);
            this.rdoDesc.TabIndex = 28;
            this.rdoDesc.TabStop = true;
            this.rdoDesc.Text = "التحضير";
            this.rdoDesc.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(716, 77);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxSearch.Size = new System.Drawing.Size(390, 29);
            this.tbxSearch.TabIndex = 29;
            this.tbxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // tbxFoodeName
            // 
            this.tbxFoodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFoodeName.Location = new System.Drawing.Point(133, 108);
            this.tbxFoodeName.Name = "tbxFoodeName";
            this.tbxFoodeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxFoodeName.Size = new System.Drawing.Size(260, 29);
            this.tbxFoodeName.TabIndex = 30;
            this.tbxFoodeName.WordWrap = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 76);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(75, 27);
            this.lblCode.TabIndex = 31;
            this.lblCode.Text = "كود الاكلة:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 556);
            this.ControlBox = false;
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.tbxFoodeName);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.rdoDesc);
            this.Controls.Add(this.rdoCom);
            this.Controls.Add(this.rdoCtgr);
            this.Controls.Add(this.rdoName);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSuggestFood);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.tbxSuggestCtgr);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnDelAllCom);
            this.Controls.Add(this.btnDelLastCom);
            this.Controls.Add(this.btnDelSlcCom);
            this.Controls.Add(this.lbxCom);
            this.Controls.Add(this.btnAddCom);
            this.Controls.Add(this.tbxCom);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.btnAddCtg);
            this.Controls.Add(this.tbxCtg);
            this.Controls.Add(this.lblCtg);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.tbxImg);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.TextBox tbxImg;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox tbxCtg;
        private System.Windows.Forms.Label lblCtg;
        private System.Windows.Forms.Button btnAddCtg;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.TextBox tbxCom;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ListBox lbxCom;
        private System.Windows.Forms.Button btnDelSlcCom;
        private System.Windows.Forms.Button btnDelLastCom;
        private System.Windows.Forms.Button btnDelAllCom;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox tbxSuggestCtgr;
        private System.Windows.Forms.Button btnSuggestFood;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoCtgr;
        private System.Windows.Forms.RadioButton rdoCom;
        private System.Windows.Forms.RadioButton rdoDesc;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxFoodeName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
        private System.Windows.Forms.DataGridViewImageColumn foodImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCtgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCode;
    }
}

