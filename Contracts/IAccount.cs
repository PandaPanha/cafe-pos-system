using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Contracts
{
    public interface IAccount
    {
        Account GetUserCredentials(string username, string password);
        Account GetAccountByStaffId(int staffId);

        List<Account> GetAllAccount();
    }
}
