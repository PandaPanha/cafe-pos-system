using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Contracts
{
    internal interface IUser
    {
        void CreateUser(string staffId, string username, string password , string commirmPassword, string userType);

    }
}
