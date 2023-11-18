using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{
    
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public Boolean IsValidAccount()
        {
            if (Id == 0 || UserType == "") { return false; } 
            return true;
        }
    }
}
