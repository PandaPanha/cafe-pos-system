using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Models
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public char Gender { get; set;}
        public DateTime BirthDate { get; set; }
        public float Salary { get; set; }   
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address{ get; set; }
        public DateTime hireDate { get; set; }
        public Boolean StopWork { get; set; }
        
        public Staff() { }
        public Staff(int staffId, string staffName, char gender, DateTime birthDate, float salary, string position, string email, string phone, string address, DateTime hireDate, bool stopWork)
        {
            StaffId = staffId;
            StaffName = staffName;
            Gender = gender;
            BirthDate = birthDate;
            Salary = salary;
            Position = position;
            Email = email;
            Phone = phone;
            Address = address;
            this.hireDate = hireDate;
            StopWork = stopWork;
        }

    }
}
