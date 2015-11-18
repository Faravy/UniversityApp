using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    class CourseAssignManager
    {
        CourseAssignGateway courseAssignGateway = new CourseAssignGateway();

        public string Save(CourseAssignToTeacher courseAssign)
        {
            CourseAssignToTeacher courseCheck = courseAssignGateway.FindCourse(courseAssign.Course_id);
            if (courseCheck == null)
            {
                courseAssignGateway.Save(courseAssign);
                return "Course Assigned";
            }
            return "Course Already Assigned";

        }
    }
}
