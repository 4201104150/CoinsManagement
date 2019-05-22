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
    public partial class frmQLNV : Form
    {
        OracleConnection con;
        public frmQLNV()
        {
            this.setConnection();
            InitializeComponent();
        }
        /// <summary>
        /// create nhanvien
        /// </summary>
        private void insNhanVien()
        {
            int i = 0;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into nhanvien values ('"+(++i)+"','"+ txtUS.Text + "','"+txtPS.Text+"','"+txtHoTen+"','"+txtDiaChi.Text+"','"+txtCMND.Text+"')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        private void updNhanVien()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "update nhanvien set Password='" + txtPS.Text + "',hoten='" + txtHoTen.Text + "',diachi='" + txtDiaChi.Text + "',CMND='" + txtCMND.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        private void delNhanVien()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete NHANVIEN Where USERNAME="+txtUS.Text;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        private void updateDatagridviewDSNV()
        {

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from NHANVIEN";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                dataGridViewNhanVien.DataSource = dt;
            }
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insNhanVien();
            updateDatagridviewDSNV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delNhanVien();
            updateDatagridviewDSNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updNhanVien();
            updateDatagridviewDSNV();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            updateDatagridviewDSNV();
        }
    }
}
