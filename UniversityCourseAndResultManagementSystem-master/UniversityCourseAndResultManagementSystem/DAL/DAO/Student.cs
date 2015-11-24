using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    class Student
    {
        public Student()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
        public string RegNo { get; set; }

        public Student(string name, string email, string contactNo, DateTime date, string address, int deptId,string regNo)
        {
            Name = name;
            Email = email;
            ContactNo = contactNo;
            Date = date;
            Address = address;
            DeptId = deptId;
            RegNo = regNo;
        }
    }

}
