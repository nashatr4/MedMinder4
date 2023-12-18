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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime inputTime = dateTimePickerInitialTime.Value;

            if (currentTime.Year == inputTime.Year && currentTime.Month == inputTime.Month && currentTime.Day == inputTime.Day && currentTime.Hour == inputTime.Hour && currentTime.Minute == inputTime.Minute && currentTime.Second == inputTime.Second)
            {
                timer1.Stop();
                MessageBox.Show("Teke your medicine now!");
            }
        }
    }
}
