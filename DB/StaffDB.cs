using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe_pos_system.Models;

namespace cafe_pos_system.DB
{
    public class StaffDB
    {
        private SqlConnection con = POSCafeDB.GetConnection();
    }

}
