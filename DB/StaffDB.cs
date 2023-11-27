using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe_pos_system.Contracts;
using cafe_pos_system.Models;
using cafe_pos_system.services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cafe_pos_system.DB
{
    public class StaffDB: IStaff
    {
        private SqlConnection con = POSCafeDB.GetConnection();

        public void DeleteStaffById(int staffId)
        {
            try
            {
                string storeProcedureName = "spDeleteStaff";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;

                con.Open();

                command.Parameters.AddWithValue("@staffId", staffId);

                command.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Staff> GetStaff()
        {
            try
            {
                string storedProcedureName = "spGetStaff";
                SqlCommand command = new SqlCommand(storedProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Staff> staffs = new List<Staff>();
                while (reader.Read())
                {
                    Staff staff = new Staff();
                    staff.Id = int.Parse(reader["staffId"].ToString());
                    staff.Name = reader["staffName"].ToString();
                    staff.Gender = reader["gender"].ToString();
                    staff.BirthDate = DateTime.Parse(reader["birthDate"].ToString()).ToShortDateString();
                    staff.Salary = decimal.Parse(reader["salary"].ToString());
                    staff.Position = reader["position"].ToString();
                    staff.Email = reader["email"].ToString();
                    staff.Phone = reader["phone"].ToString();
                    staff.Address = reader["address"].ToString();
                    staff.HiredDate = DateTime.Parse(reader["hiredDate"].ToString()).ToShortDateString();
                    staff.StopWork = Boolean.Parse(reader["stopWork"].ToString());
                    staff.Photo = PictureService.ConvertBinaryToImg((byte[])reader["photo"]);
                    staffs.Add(staff);
                }
                reader.Close();
                con.Close();

                return staffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public Staff GetStaffById(int staffId)
        {
            try
            {
                Staff staff = new Staff();
                string storedProcedureName = "spGetStaffById";
                SqlCommand command = new SqlCommand(storedProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@staffId", staffId);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    staff.Id = int.Parse(reader["staffId"].ToString());
                    staff.Name = reader["staffName"].ToString();
                    staff.Gender = reader["gender"].ToString();
                    staff.BirthDate = DateTime.Parse(reader["birthDate"].ToString()).ToShortDateString();
                    staff.Salary = decimal.Parse(reader["salary"].ToString());
                    staff.Position = reader["position"].ToString();
                    staff.Email = reader["email"].ToString();
                    staff.Phone = reader["phone"].ToString();
                    staff.Address = reader["address"].ToString();
                    staff.HiredDate = DateTime.Parse(reader["hiredDate"].ToString()).ToShortDateString();
                    staff.StopWork = Boolean.Parse(reader["stopWork"].ToString());
                    staff.Photo = new Bitmap(PictureService.ConvertBinaryToImg((byte[])reader["photo"]));

                }
                reader.Close();
                con.Close();
                return staff;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public void InsertStaff(Staff staff)
        {
            try
            {
                string storeProcedureName = "spInsertStaff";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                con.Open();

                command.Parameters.AddWithValue("@staffName", staff.Name);
                command.Parameters.AddWithValue("@gender", staff.Gender);
                command.Parameters.AddWithValue("@birthDate", DateTime.Parse(staff.BirthDate));
                command.Parameters.AddWithValue("@salary", staff.Salary);
                command.Parameters.AddWithValue("@position", staff.Position);
                command.Parameters.AddWithValue("@email", staff.Email);
                command.Parameters.AddWithValue("@phone", staff.Phone);
                command.Parameters.AddWithValue("@address", staff.Address);
                command.Parameters.AddWithValue("@hiredDate", DateTime.Parse(staff.HiredDate));
                command.Parameters.AddWithValue("@stopWork", staff.StopWork);
                command.Parameters.AddWithValue("@photo", PictureService.ConvertImgToBinary(staff.Photo));

                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void UpdateStaff(Staff staff)
        {
            try
            {
                string storeProcedureName = "spUpdateStaff";
                SqlCommand command = new SqlCommand(storeProcedureName, con);
                command.CommandType = CommandType.StoredProcedure;
                con.Open();
                command.Parameters.AddWithValue("@staffId", staff.Id);
                command.Parameters.AddWithValue("@staffName", staff.Name);
                command.Parameters.AddWithValue("@gender", staff.Gender);
                command.Parameters.AddWithValue("@birthDate", DateTime.Parse(staff.BirthDate));
                command.Parameters.AddWithValue("@salary", staff.Salary);
                command.Parameters.AddWithValue("@position", staff.Position);
                command.Parameters.AddWithValue("@email", staff.Email);
                command.Parameters.AddWithValue("@phone", staff.Phone);
                command.Parameters.AddWithValue("@address", staff.Address);
                command.Parameters.AddWithValue("@hiredDate", DateTime.Parse(staff.HiredDate));
                command.Parameters.AddWithValue("@stopWork", staff.StopWork);
                command.Parameters.AddWithValue("@photo", PictureService.ConvertImgToBinary(staff.Photo));

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
