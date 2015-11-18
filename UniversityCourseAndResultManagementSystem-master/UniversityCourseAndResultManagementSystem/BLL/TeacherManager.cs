using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    class TeacherManager
    {
        TeacherGateway teacherGateway=new TeacherGateway();

        public string Save(Teacher teacher)
        {
            Teacher emailCheck = teacherGateway.FindEmail(teacher.Email);
            if (emailCheck==null)
            {
                teacherGateway.Save(teacher);
                return "Teacher Added";
            }
            return "Email Already Exists";

        }
    }
}
