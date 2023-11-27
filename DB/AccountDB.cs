using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cafe_pos_system.DB
{
    public class AccountDB : IAccount
    {
        private SqlConnection con = POSCafeDB.GetConnection();

        public Account GetAccountByStaffId(int staffId)
        {
            try
            {
                Account account = new Account();
                string storedProcedureName = "spAccountByStaffId";
                SqlCommand command = new SqlCommand(storedProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@inputStaffId", staffId);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    account.Id = int.Parse(reader["accountId"].ToString());
                    account.Username = reader["username"].ToString();
                    account.Password = reader["password"].ToString();
                    account.UserType = reader["userType"].ToString();
                }
                con.Close();
                return account;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public List<Account> GetAllAccount()
        {
            try
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
                    account.StaffId = int.Parse(reader["staffId"].ToString());
                    accounts.Add(account);
                }
                con.Close();

                return accounts;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public Account GetUserCredentials(string username, string password)
        {
            try
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
                    account.Password = reader["password"].ToString();
                    account.UserType = reader["userType"].ToString();
                    account.StaffId = int.Parse(reader["staffId"].ToString());
                }
                con.Close();
                return account;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\n Please check your connection string", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void InsertAccount(Account account)
        {
            try
            {
                string storeProcedureName = "spInsertAccount";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                con.Open();

                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@userType", account.UserType);
                command.Parameters.AddWithValue("@staffId", account.StaffId);

                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAccount(Account account)
        {
            try
            {
                string storeProcedureName = "spUpdateAccount";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                con.Open();
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@userType", account.UserType);
                command.Parameters.AddWithValue("@staffId", account.StaffId);

                command.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void DeleteAccountById(int accountId)
        {
            try
            {
                string storeProcedureName = "spDeleteAccount";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;

                con.Open();

                command.Parameters.AddWithValue("@accountId", accountId);

                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
