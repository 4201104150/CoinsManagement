using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinsManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //lọc dữ liệu theo ngày, loại coin được chon

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load data mặt định là bit coin

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            frmTimKiem f = new frmTimKiem();
            f.ShowDialog();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuuData f = new frmLuuData();
            f.ShowDialog();
        }
    }
}
