using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SAFE_DESIGN.Forms
{
    public partial class _1_a_Bagian_Informasi : Form
    {
        public _1_a_Bagian_Informasi(string value)
        {
            InitializeComponent();
            this.Value = value;
            lbl_kondisi.Text = Value;
            munculkan();
        }

        public string Value { get; set; }
        public void munculkan()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DJH161QP;Initial Catalog=databasesafe;Integrated Security=True");
            con.Open();
            string q = "select penyebab, penanganan from databasesafe where keadaan = '" + lbl_kondisi.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_penanganan.Text = dr[1].ToString();
                tb_gejala.Text = dr[0].ToString();
            }
            con.Close();
        }
        private void button_close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void button_minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        public void informasi()
        {

        }
        private void _1_a_Bagian_Informasi_Load(object sender, EventArgs e)
        {
            lbl_kondisi.Text = Value;
        }
    }
}
