using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Contracts
{
    public interface IStaff
    {
        List<Staff> GetStaff();
        Staff GetStaffById(int staffId);
        void InsertStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaffById(int staffId);
    }
}
