using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{

    public class Staff
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public decimal Salary {  get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string HiredDate { get; set; }
        public Boolean StopWork { get; set; }
        public Image Photo {  get; set; }

    }
}
