using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetAuto()
        {
            tbxFoodeName.Select();
            tbxFoodeName.Text = "";
            tbxCtg.Text = "";
            tbxImg.Text = "";
            lbxCom.Items.Clear();
            tbxDesc.Text = "";
            img.Image = new PictureBox().Image;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            DataTable tbl = DB.GetData("select max(FoodCode)+1 from food");
            tbxCode.Text = tbl.Rows[0][0].ToString();
            if (tbxCode.Text.Trim() == "") tbxCode.Text = "1";
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DB.Open();
            showTbl();
            GetAuto();
        }
        bool isMouseDown = false;
        Point local = new Point();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            Cursor = Cursors.Hand;
            local = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                var x = (this.Location.X - local.X) + e.X;
                var y = (this.Location.Y - local.Y) + e.Y;
                this.Location = new Point(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            Cursor = Cursors.Hand;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Images |*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbxImg.Text = ofd.FileName;
                    Bitmap bmp = new Bitmap(Image.FromFile(tbxImg.Text), 81, 65);
                    img.Image = bmp;
                }
            }                                     
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
            DB.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnAddCtg_Click(object sender, EventArgs e)
        {
            tbxCtg.Text = "";
            Frmctgrs frmCtrgs = new Frmctgrs();
            frmCtrgs.ShowDialog();
            string x = "";
            foreach(var i in V.categories)
            {
                var comma = (i.Item1 != V.categories[V.categories.Count - 1].Item1) ? x = ", ": x="";
                tbxCtg.Text += $"{i.Item2}{comma}";
            }
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            if(tbxCom.Text.Trim() != "")
            {
                lbxCom.Items.Add(tbxCom.Text);
            }
            string[] str1 = new string[lbxCom.Items.Count];
            lbxCom.Items.CopyTo(str1, 0);
            lbxCom.Items.Clear();
            string[] str2 = str1.Distinct().ToArray();
            lbxCom.Items.AddRange(str2);
            tbxCom.Clear();
            tbxCom.Select();
        }

        private void tbxCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return") btnAddCom.PerformClick();
        }

        private void btnDelSlcCom_Click(object sender, EventArgs e)
        {
            if (lbxCom.SelectedItem == null) return;
            if(lbxCom.Items.Count > 0) lbxCom.Items.RemoveAt(lbxCom.SelectedIndex);
        }

        private void btnDelLastCom_Click(object sender, EventArgs e)
        {
            if (lbxCom.Items.Count > 0) lbxCom.Items.RemoveAt(lbxCom.Items.Count-1);
        }

        private void btnDelAllCom_Click(object sender, EventArgs e)
        {
            if (lbxCom.Items.Count > 0) lbxCom.Items.Clear();
        }
        DataTable tempTbl = new DataTable();
        private void btnNew_Click(object sender, EventArgs e)
        {
            showTbl();
            GetAuto();
        }
        DataTable tblAll = new DataTable();
        public void showTbl()
        {
            tblAll.Rows.Clear();
            DataTable tblFoodData = DB.GetData("select * from data");
            DataTable tblDataCtgr = DB.GetData("select * from data_ctgr");
            DataTable tblComponents = DB.GetData("select * from foodComponents");
            if(tblAll.Columns.Count < 1)
            {
                tblAll.Columns.Add("foodCode");
                tblAll.Columns.Add("foodName");
                tblAll.Columns.Add("foodImg", typeof(byte[]));
                tblAll.Columns.Add("categoryName");
                tblAll.Columns.Add("foodCom");
                tblAll.Columns.Add("foodDesc");
            }
            for (int i = 0; i < tblFoodData.Rows.Count; i++)
            {
                DataRow row = tblAll.NewRow();
                row[0] = tblFoodData.Rows[i][0];
                row[1] = tblFoodData.Rows[i][1];
                row[2] = tblFoodData.Rows[i][2];
                string strCtgr = "";
                DataRow[] rowCtgr = tblDataCtgr.Select($"foodCode={tblFoodData.Rows[i][0].ToString()}");
                foreach (var ctgr in rowCtgr) { strCtgr += ctgr[1] + Environment.NewLine; }
                row[3] = strCtgr;
                string strCom = "";
                DataRow[] rowCom = tblComponents.Select($"foodCode={tblFoodData.Rows[i][0].ToString()}");
                foreach (var com in rowCom) { strCom += com[1] + Environment.NewLine; }
                row[4] = strCom;
                row[5] = tblFoodData.Rows[i][3];
                tblAll.Rows.Add(row);
            }
            DataTable tempTbl = tblAll;
            dgv.DataSource = tblAll;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            lblText.Text = ">>";
            if (tbxFoodeName.Text.Trim() == "")
                lblText.Text = "المرجو اضافة اسم الاكلة";
            else if (tbxImg.Text.Trim() == "")
                lblText.Text = "اضافة الصورة";
            else if (tbxCtg.Text.Trim() == "")
                lblText.Text = "اضافة التصنيفات";
            else if (lbxCom.Items.Count <= 0)
                lblText.Text = "اضافة المقادير";
            else if (tbxDesc.Text.Trim() == "")
                lblText.Text = "اضافة الوصف";
            else
            {
                try
                {
                    DB.Run($"insert into food values({tbxCode.Text}, \"{tbxFoodeName.Text}\", '{tbxDesc.Text}')");
                    lblText.Text += "تمت اضافة اسم الاكلة ,";
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Image.Save(ms, ImageFormat.Png);
                        DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                        DB.Run($"insert into foodImgs values({tbxCode.Text}, @img)");
                        lblText.Text += "تمت اضافة الصورة ,";
                    }
                    foreach (var i in V.categories)
                    {
                        DB.Run($"insert into foodCategory values({tbxCode.Text}, {i.Item1})");
                        lblText.Text += "تمت اضافة التصنيفات ,";
                    }
                    foreach (var i in lbxCom.Items)
                    {
                        DB.Run($"insert into foodComponents values({tbxCode.Text}, '{i.ToString()}')");
                        lblText.Text += "تمت اضافة المقادير";
                    }
                } catch (Exception ex)
                { MessageBox.Show($"{ex.Message}"); }
                tbxFoodeName.Text = "";
                tbxCtg.Text = "";
                tbxImg.Text = "";
                lbxCom.Items.Clear();
                tbxDesc.Text = "";
                img.Image = new PictureBox().Image;
                showTbl();
                GetAuto();
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                V.categories.Clear();
                tbxCtg.Text = "";
                tbxCode.Text = (string)dgv.CurrentRow.Cells[0].Value;
                tbxFoodeName.Text = (string)dgv.CurrentRow.Cells[1].Value;
                using (MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[2].Value)) { img.Image = Image.FromStream(ms); }
                DataTable CtgrTbl = DB.GetData($"select * from data_ctgr where foodCode={dgv.CurrentRow.Cells[0].Value}");
                foreach(DataRow row in CtgrTbl.Rows) { V.categories.Add(new Tuple<int, string>((int)row[2], (string)row[1])); }
                string x = "";
                foreach(var i in V.categories)
                {
                    var comma = (i.Item1 != V.categories[V.categories.Count - 1].Item1) ? x = ", " : x = "";
                    tbxCtg.Text += $"{i.Item2}{comma}";
                }
                DataTable tblCom = DB.GetData($"select * from foodComponents where foodCode = {tbxCode.Text}");
                lbxCom.Items.Clear();
                foreach(DataRow row in tblCom.Rows) { lbxCom.Items.Add(row[1]); }
                tbxDesc.Text = (string)dgv.CurrentRow.Cells[5].Value;
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            lblText.Text = ">>";
            if (tbxFoodeName.Text.Trim() == "")
                lblText.Text = "المرجو اضافة اسم الاكلة";
            else if (tbxCtg.Text.Trim() == "")
                lblText.Text = "اضافة التصنيفات";
            else if (lbxCom.Items.Count <= 0)
                lblText.Text = "اضافة المقادير";
            else if (tbxDesc.Text.Trim() == "")
                lblText.Text = "اضافة الوصف";
            else
            {
                try
                {
                    DB.Run($"update food set foodName='{tbxFoodeName.Text.ToString()}', foodDesc='{tbxDesc.Text.ToString()}' where foodCode={tbxCode.Text}");
                    lblText.Text += "تمت اضافة اسم الاكلة ,";
                    if (tbxImg.Text.Trim() != "")
                    {
                        DB.Run($"delete from foodImgs where foodCode={tbxCode.Text}");
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Image.Save(ms, ImageFormat.Png);
                            DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                            DB.Run($"insert into foodImgs values({tbxCode.Text}, @img)");
                            lblText.Text += "تمت اضافة الصورة ,";
                        }

                        DB.Run($"delete from foodCategory where foodCode={tbxCode.Text}");
                        foreach (var i in V.categories)
                        {
                            DB.Run($"insert into foodCategory values({tbxCode.Text}, {i.Item1})");
                            lblText.Text += "تمت اضافة التصنيفات ,";
                        }
                        DB.Run($"delete from foodComponents where foodCode={tbxCode.Text}");
                        foreach (var i in lbxCom.Items)
                        {
                            DB.Run($"insert into foodComponents values({tbxCode.Text}, '{i.ToString()}')");
                            lblText.Text += "تمت اضافة المقادير";
                        }
                    }
                } catch (Exception ex)
                { MessageBox.Show($"{ex.Message}"); }
                showTbl();
                GetAuto();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            lblText.Text = ">>";
            if (tbxFoodeName.Text.Trim() == "")
                lblText.Text = "المرجو اضافة اسم الاكلة";
            else if (tbxCtg.Text.Trim() == "")
                lblText.Text = "اضافة التصنيفات";
            else if (lbxCom.Items.Count <= 0)
                lblText.Text = "اضافة المقادير";
            else if (tbxDesc.Text.Trim() == "")
                lblText.Text = "اضافة الوصف";
            else
            {
                try
                {
                    DB.Run($"delete from food where foodCode={tbxCode.Text}");
                    lblText.Text += "تمت اضافة اسم الاكلة ,";
                    DB.Run($"delete from foodImgs where foodCode={tbxCode.Text}");
                    DB.Run($"delete from foodCategory where foodCode={tbxCode.Text}");
                    DB.Run($"delete from foodComponents where foodCode={tbxCode.Text}");
                }
                catch (Exception ex)
                { MessageBox.Show($"{ex.Message}"); }
                showTbl();
                GetAuto();
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Icon = Icon;
            ReportDataSource rdb = new ReportDataSource("DataSet1", tblAll);
            report.rv.LocalReport.DataSources.Clear();
            report.rv.LocalReport.DataSources.Add(rdb);
            report.rv.LocalReport.Refresh();
            report.ShowDialog();
        }
        
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

            string str = "";
            if (rdoName.Checked) str += "foodName";
            else if (rdoCtgr.Checked) str += "categoryName";
            else if (rdoCom.Checked) str += "foodCom";
            else str += "foodDesc";
            str += " like'%" + tbxSearch.Text + "%'";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv.DataSource;
            bs.Filter = str;
            dgv.DataSource = bs.DataSource;
        }

        private void btnSuggestFood_Click(object sender, EventArgs e)
        {
            if(tblAll.Rows.Count > 0)
            {
                Random r = new Random();
                int randIndex = r.Next(0, tblAll.Rows.Count);
                suggestFood suggestFood = new suggestFood();
                suggestFood.Icon = Icon;
                suggestFood.tbxFoodName.Text = (string)tblAll.Rows[randIndex][1];
                suggestFood.tbxCtgrs.Text = (string)tblAll.Rows[randIndex][3];
                suggestFood.tbxComs.Text = (string)tblAll.Rows[randIndex][4];
                //suggestFood.tbxDesc.Text = tblAll.Rows[randIndex][5].ToString();
                MemoryStream ms = new MemoryStream((byte[])tblAll.Rows[randIndex][2]);
                suggestFood.img.Image = Image.FromStream(ms);
                suggestFood.ShowDialog();
            }
        }
    }
}
