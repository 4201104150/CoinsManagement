using Oracle.ManagedDataAccess.Client;
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
    public partial class frmTimKiem : Form
    {
        public static string s = "";
        public static string ss = "";
        public frmTimKiem()
        {            
            InitializeComponent();
        }
        
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            s = "USD";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            s = cbbLoaiCoin.Text;
            ss = txtLoaiCoin.Text;
            frmDataFindedcs f = new frmDataFindedcs();
            f.ShowDialog();
        }
    }
}
