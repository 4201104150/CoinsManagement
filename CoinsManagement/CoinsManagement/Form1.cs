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
using Newtonsoft.Json;

namespace CoinsManagement
{
    public partial class Form1 : Form
    {
        OracleConnection con;
        public Form1()
        {
            this.setConnection();
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
        private void updateDatagridview(string s)
        {
         
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM COIN"+s;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private static string API_KEY = "0c1437b5-12b4-4f1d-90e1-83a8eefc892f";
        /// <summary>
        /// function get data coins
        /// </summary>
        static string makeAPICall(string typeConvert)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "5000";
            queryString["convert"] = typeConvert;

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());

        }
        /// <summary>
        /// function insert data to database
        /// </summary>
        private void InsertDuLieu(string nameDB)
        {
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(makeAPICall(nameDB));
            OracleCommand cmd = con.CreateCommand();
            for (int i = 0; i < 2178; i++)
            {
                int id = int.Parse((string)jObject["data"][i]["id"]);
                string name = (string)jObject["data"][i]["name"];
                string symbol = (string)jObject["data"][i]["symbol"];
                string slug = (string)jObject["data"][i]["slug"];
                string rank = (string)jObject["data"][i]["cmc_rank"];

                string price = ((string)jObject["data"][i]["quote"][nameDB]["price"]);
                string percent_change_1h = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_1h"]);
                string percent_change_24h = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_24h"]);
                string percent_change_7d = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_7d"]);
                string last_updated = ((string)jObject["data"][i]["quote"][nameDB]["last_updated"]);


                cmd.CommandText ="insert into COIN"+nameDB+" values ('" + id + "','" + name + "','" + symbol + "','" + slug + "','" + rank + "','" + price + "','" + percent_change_1h + "','" + percent_change_24h + "','" + percent_change_7d + "','" + last_updated + "')";
                cmd.CommandType = CommandType.Text;
                if (i == 2177)
                {
                    cmd.ExecuteNonQuery();
                    break;
                }
            }
        }
        /// <summary>
        /// function update data
        /// </summary>
        /// <param name="nameDB"></param>
        private void UpdateDuLieu(string nameDB)
        {
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(makeAPICall(nameDB));
            OracleCommand cmd = con.CreateCommand();
            for (int i = 0; i < 2178; i++)
            {
                int id = int.Parse((string)jObject["data"][i]["id"]);
                string name = (string)jObject["data"][i]["name"];
                string symbol = (string)jObject["data"][i]["symbol"];
                string slug = (string)jObject["data"][i]["slug"];
                string rank = (string)jObject["data"][i]["cmc_rank"];

                string price = ((string)jObject["data"][i]["quote"][nameDB]["price"]);
                string percent_change_1h = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_1h"]);
                string percent_change_24h = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_24h"]);
                string percent_change_7d = ((string)jObject["data"][i]["quote"][nameDB]["percent_change_7d"]);
                string last_updated = ((string)jObject["data"][i]["quote"][nameDB]["last_updated"]);


                cmd.CommandText = "update COIN" + nameDB + " set NAMES='" + name + "',SYMBOL='" + symbol + "',SLUG='" + slug + "',RANKS='" + rank + "',PRICE='" + price + "',CHANGE1H='" + percent_change_1h + "',CHANGE24H='" + percent_change_24h + "',CHANGE7D='" + percent_change_7d + "',UPDATES='" + last_updated + "')";
                cmd.CommandType = CommandType.Text;
                if (i == 2177)
                {
                    cmd.ExecuteNonQuery();
                    break;
                }
            }
        }

        /// <summary>
        /// load lại data từ api
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoc_Click(object sender, EventArgs e)
        {
            updateDatagridview("USD");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateDatagridview("USD");
            lbTien.Text = "USD";
            timer1.Start();
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
            updateDatagridview("USD");
            lbTien.Text = "USD";
        }

        private void btnfirstrun_Click(object sender, EventArgs e)
        {
            InsertDuLieu("USD");
            InsertDuLieu("JPY");
            InsertDuLieu("VND");
            InsertDuLieu("EUR");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDuLieu("USD");
            UpdateDuLieu("JPY");
            UpdateDuLieu("VND");
            UpdateDuLieu("EUR");
        }

        private void datacoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDatagridview("VND");
            lbTien.Text = "VND";
        }

        private void jPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDatagridview("JPY");
            lbTien.Text = "JPY";
        }

        private void eURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDatagridview("EUR");
            lbTien.Text = "EUR";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
