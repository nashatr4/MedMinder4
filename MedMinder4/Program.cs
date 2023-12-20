using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MedMinder4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False");
            SqlDataReader baca = new SqlDataReader(connection);

        }

        
    }
}
