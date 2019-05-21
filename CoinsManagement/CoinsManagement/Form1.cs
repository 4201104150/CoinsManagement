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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Windows;
using System.Data.SqlClient;

namespace CoinsManagement
{
    public partial class Form1 : Form
    {
        OracleConnection con;
        public Form1()
        {
            this.setConnection();
            //this.setConnection();
            InitializeComponent();
        }
        private void setConnection()
        {
            String connectionString = "USER ID=SYSTEM;PASSWORD=Doraemon98;DATA SOURCE=localhost:1521/orclc;Pooling=false";
            con = new OracleConnection();
            con.ConnectionString = connectionString;
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// updata
        /// </summary>-
        private void updateDatagridview()
        {
         
            OracleCommand cmd = con.CreateCommand();
            OracleCommand cmd2 = con.CreateCommand();
            cmd.CommandText = "SELECT IDD FROM COIN ";
            cmd2.CommandText = "DELETE FROM COIN WHERE IDD='99' ";
            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            OracleDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if(dt!=null)
            {
                MessageBox.Show("!null");
            }
            else
            {
                MessageBox.Show("null");
            }
            //dt.Dispose();
            //Console.Write(dt);
            
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
            this.updateDatagridview();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void bitcoinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
