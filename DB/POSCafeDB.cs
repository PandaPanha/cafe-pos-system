using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.DB
{
    public static class POSCafeDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4FMPOU4\SQLEXPRESS;Initial Catalog=dbCafe_POS;Integrated Security=True");
            return sqlConnection;
        }
    }
}
