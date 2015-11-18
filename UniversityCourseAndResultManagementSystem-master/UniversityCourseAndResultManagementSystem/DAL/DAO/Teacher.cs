using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact_No { get; set; }
        public int Designation_id { get; set; }
        public int Department_id { get; set; }
        public double Credit_Taken { get; set; }

        public Teacher( string name, string address, string email, string contactNo, int designationId, int departmentId, double creditTaken)
        {
            
            Name = name;
            Address = address;
            Email = email;
            Contact_No = contactNo;
            Designation_id = designationId;
            Department_id = departmentId;
            Credit_Taken = creditTaken;
        }

        public Teacher()
        {
        }
    }
}
