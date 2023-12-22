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
            Conn.ConnectionString = "Data Source=LAPTOP-T4R0VNG1; initial catalog=LOGIN; integrated security=true";
            return Conn;
        }
    }
}
