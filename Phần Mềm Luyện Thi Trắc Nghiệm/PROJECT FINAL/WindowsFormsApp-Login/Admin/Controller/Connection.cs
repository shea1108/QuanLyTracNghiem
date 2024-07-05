using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp_Login
{
    class Connection
    {
        public static string stringConnection = @"Data Source=SHEA\SQLEXPRESS02;Initial Catalog=QuanLyAppTracNghiem;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
