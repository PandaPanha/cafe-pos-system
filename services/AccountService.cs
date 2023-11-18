using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system.services
{
    public class AccountService : IAccount
    {
        AccountDB accountDB = new AccountDB();

        

        public Account GetAccountByStaffId(int staffId)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAllAccount()
        {
            return accountDB.GetAllAccount();
        }

        public Account GetUserCredentials(string username, string password)
        {
            return accountDB.GetUserCredentials(username, password);

        }
    }
}
