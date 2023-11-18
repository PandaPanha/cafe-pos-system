using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{

    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName{ get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public SqlMoney Salary {  get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HiredDate { get; set; }
        public Boolean StopWork { get; set; }
        public SqlBinary Photo {  get; set; }

    }
}
