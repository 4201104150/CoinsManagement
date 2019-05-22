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
    public partial class frmDataFindedcs : Form
    {
        OracleConnection con;
        public frmDataFindedcs()
        {
            setConnection();
            
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
        string s = frmTimKiem.ss;
        string ss = frmTimKiem.s;
        private void updateDatagridview(string sla)
        {

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM COIN" + sla +" Where NAMES='"+s+"'";
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

        private void frmDataFindedcs_Load(object sender, EventArgs e)
        {
            updateDatagridview(ss);
        }
    }
}
