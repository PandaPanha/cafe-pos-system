using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.DB
{
    public class AccountDB : IAccount, IUser
    {
        private SqlConnection con = POSCafeDB.GetConnection();

        public Account GetAccountByStaffId(int staffId)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAllAccount()
        {
            
            string storedProcedureName = "spGetAccount";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.Id = int.Parse(reader["accountId"].ToString());
                account.Username = reader["username"].ToString();
                account.Password = reader["password"].ToString();
                account.UserType = reader["userType"].ToString();
                accounts.Add(account);
            }
            con.Close();

            return accounts;
        }

        public Account GetUserCredentials(string username, string password)
        {
            Account account = new Account();
            string storedProcedureName = "spGetUserCredentials";
            SqlCommand command = new SqlCommand(storedProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@inputUsername", username);
            command.Parameters.AddWithValue("@inputPassword", password);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                account.Id = int.Parse(reader["accountId"].ToString());
                account.Username = reader["username"].ToString();
                account.UserType = reader["userType"].ToString();
            }
            con.Close();
            return account;
        }

        public void CreateUser(string staffId, string username, string password, string userType)
        {
            string storeProcedureName = "spInsertAccount";
            SqlCommand command= new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;
            con.Open(); 
            
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@userType", userType);
            command.Parameters.AddWithValue("@staffId", staffId);

            command.ExecuteNonQuery();

            con.Close();

        }
    }
}
