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
using System.Net.Http;

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
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Medicine4]
           ([MedicineName]
           ,[ConsumptionTime]
           ,[InitialTime]
           ,[AmountofMedicine])
     VALUES
           ('" + textBoxMedName.Text + "', '" + numericUpDownConsumptionTime.Value + "', '" + dateTimePickerInitialTime.Value + "', '" + numericUpDownAmountofMedicine.Value + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Medicine Added");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }


    }
}
