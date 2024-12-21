using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
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
            Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.rv.RefreshReport();
        }
    }
}
