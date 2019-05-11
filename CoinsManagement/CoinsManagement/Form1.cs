using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace CoinsManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string API_KEY = "0c1437b5-12b4-4f1d-90e1-83a8eefc892f";
        /// <summary>
        /// function get data coins
        /// </summary>
        static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "5000";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());

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
