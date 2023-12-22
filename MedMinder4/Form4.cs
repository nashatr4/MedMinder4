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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string constring = "Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False";
             string query = "DELETE FROM Medicine4 WHERE MedicineName = '" + this.textBoxMedName1.Text + "'";
             SqlConnection conn = new SqlConnection(constring);
             SqlCommand cmd = new SqlCommand(query, conn);
             SqlDataReader reader;
             try
             {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Deleted Medicine");
                while (reader.Read())
                {

                }
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
