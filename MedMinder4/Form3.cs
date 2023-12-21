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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MedMinder4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Medicine2]
           ([Medicine Name]
           ,[Consumption Time]
           ,[Initial Time]
           ,[Amount of Medicine])
     VALUES
           ('"+textBoxMedName.Text+"', '"+numericUpDownConsumptionTime.Value+"', '"+dateTimePickerInitialTime.Value+"', '"+numericUpDownAmountofMedicine.Value+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Medicine Added");


            Form2 balik = new Form2();
            balik.Show();
            this.Hide();

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Initial Time FROM Medicine2", connection);

            SqlDataReader reader = command.ExecuteReader();
        

            
        }
    }
}
