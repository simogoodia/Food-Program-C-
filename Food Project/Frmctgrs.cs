using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class Frmctgrs : Form
    {
        public Frmctgrs()
        {
            InitializeComponent();
        }
        public void GetAuto()
        {
            DataTable tbl = DB.GetData("select max(categoryNo)+1 from category");
            lbxCtgr.Text = tbl.Rows[0][0].ToString();
            if (lbxCtgr.Text.Trim() == "") lbxCtgr.Text = "1";
            btnNew.Enabled = true;
            btnAddCtgr.Enabled = true;
            btnDelCtgr.Enabled = false;
            tbxNameCtgr.Select();
        }
        public void ShowCategory()
        {
            dgv.DataSource = DB.GetData("select * from category");
            dgv.CurrentCell = null;
        }
        public void AutoAndShow()
        {
            ShowCategory();
            tbxNameCtgr.Text = "";
            GetAuto();
        }
        private void Frmctgrs_Load(object sender, EventArgs e)
        {
            DB.Open();
            AutoAndShow();
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
            if (isMouseDown)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseCtgrs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
            DB.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDelCtgr_EnabledChanged(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = (((Button)sender).Enabled) ? SystemColors.Control : Color.LightGray; 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxNameCtgr.Text = "";
            GetAuto();
        }

        private void btnAddCtgr_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxNameCtgr.Text.Trim() != "")
                {
                    DB.Run($"insert into category values({lbxCtgr.Text}, '{tbxNameCtgr.Text.ToString()}')");
                    AutoAndShow();
                }
            } catch(Exception ex)
            {
            }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                lbxCtgr.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                tbxNameCtgr.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                btnAddCtgr.Enabled = false;
                if (lbx.Items.Count > 0) btnDelCtgr.Enabled = false;
                else btnDelCtgr.Enabled = true;
            }
        }

        private void btnAddCtgr_EnabledChanged(object sender, EventArgs e)
        {
            btnDelCtgr_EnabledChanged(sender, e);
        }

        private void btnDelCtgr_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNameCtgr.Text.Trim() != "")
                {
                    DB.Run($"delete from category where {lbxCtgr.Text}=categoryNo");
                    AutoAndShow();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnNew_EnabledChanged(object sender, EventArgs e)
        {
            btnDelCtgr_EnabledChanged(sender, e);
        }

        List<Tuple<int, string>> data = new List<Tuple<int, string>>();
        public void setItems()
        {
            lbx.ValueMember = "Item1";
            lbx.DisplayMember = "Item2";
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Distinct();
            lbx.DataSource = bs;
            tbxNameCtgr.Text = "";
            GetAuto();
        }
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if(dgv.CurrentRow != null)
            {
                data.Add(new Tuple<int, string>((int)dgv.CurrentRow.Cells[0].Value, dgv.CurrentRow.Cells[1].Value.ToString()));
            }
            setItems();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            data.Clear();
            if(dgv.Rows.Count > 0)
            {
                foreach(DataGridViewRow i in dgv.Rows)
                {
                    data.Add(new Tuple<int, string>((int)i.Cells[0].Value, i.Cells[1].Value.ToString()));
                }
                setItems();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            data.Clear();
            lbx.DataSource = data;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            V.categories.Clear();
            if (lbx.Items.Count > 0)
            {
                for(int i = 0; i < lbx.Items.Count; i++)
                {
                    lbx.SelectedIndex = i;
                    V.categories.Add(Tuple.Create((int)lbx.SelectedValue, lbx.GetItemText(lbx.Items[i]).ToString()));
                }
                btnCloseCtgrs.PerformClick();
            }
        }

        private void tbxNameCtgr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxNameCtgr_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "Return")
            {
                btnAddCtgr.PerformClick();
            }
        }
    }
}
