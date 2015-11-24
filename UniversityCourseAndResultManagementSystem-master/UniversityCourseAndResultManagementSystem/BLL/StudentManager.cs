using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    internal class StudentManager
    {
        private StudentGateway studentGateway = new StudentGateway();

        public bool Save(Student student)
        {

            if (IsEmailAlreadyExist(student.Email))
            {
                throw new Exception("Email Already Exist");
            }
            return studentGateway.Save(student) > 0;
        }

        public bool IsEmailAlreadyExist(string email)
        {
            return studentGateway.IsEmailAlreadyExist(email) > 0;
        }

        private List<Student> GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        }

        public string CounterStudentByYearAndDept(int year,int deptId)
        {
            string count = "";
            count = (GetAllStudents().Where(a => a.DeptId == deptId && a.Date.Year == year).Count()+1).ToString();
            if (count.Length == 1)
                count = "00" + count;
            else if (count.Length == 2)
                count = "0" + count;
           return count;
        }
}
}
