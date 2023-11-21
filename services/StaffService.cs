using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.services
{
    public class StaffService : IStaff
    {
        private StaffDB staffDB = new StaffDB();

        public void DeleteStaffById(int staffId)
        {
            staffDB.DeleteStaffById(staffId);
        }

        public List<Staff> GetStaff()
        {
            return staffDB.GetStaff();
        }

        public Staff GetStaffById(int staffId)
        {
            return staffDB.GetStaffById(staffId);
        }

        public void InsertStaff(Staff staff)
        {
            staffDB.InsertStaff(staff);
        }

        public void UpdateStaff(Staff staff)
        {
            staffDB.UpdateStaff(staff);
        }
    }
}
