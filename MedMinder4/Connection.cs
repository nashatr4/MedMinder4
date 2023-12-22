using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedMinder4
{
    internal class Connection
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-HJSTJR2S\\SQLEXPRESS;Initial Catalog=MedMinder;Integrated Security=True;Encrypt=False";
            return Conn;
        }
    }
}
