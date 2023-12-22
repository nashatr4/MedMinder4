using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedMinder4
{
    public partial class Form5 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Connection Conn = new Connection();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBLLogin where KodeUser= '" + textBox1.Text + "' and PasswordUser= '" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if(rd.HasRows)
            {
                this.Hide();
                Form1 formUtama = new Form1();
                formUtama.textBoxNama.Text = "Hello " +  rd["NamaUser"].ToString() + "! ";
                formUtama.Show();

                conn.Close();
            }
            else
            {
                MessageBox.Show("Masukkan salah!");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
