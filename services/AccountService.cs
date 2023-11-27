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
        private AccountDB accountDB = new AccountDB();

        public void DeleteAccountById(int accountId)
        {
            accountDB.DeleteAccountById(accountId);
        }

        public Account GetAccountByStaffId(int staffId)
        {
            return accountDB.GetAccountByStaffId(staffId);
        }

        public List<Account> GetAllAccount()
        {
            return accountDB.GetAllAccount();
        }

        public Account GetUserCredentials(string username, string password)
        {
            return accountDB.GetUserCredentials(username, password);

        }

        public void InsertAccount(Account account)
        {
            accountDB.InsertAccount(account);
        }

        public void UpdateAccount(Account account)
        {
            accountDB.UpdateAccount(account);
        }

        public Boolean HasStaffAccount(int staffId)
        {
            List<Account> accountList = GetAllAccount();
            foreach(Account acc in accountList)
            {
                
                if(acc.StaffId == staffId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
