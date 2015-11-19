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

        public bool Save(CourseAssignToTeacher courseAssign)
        {

            if (IsCourseAlreadyAssigned(courseAssign.Course_id))
            {
                throw new Exception("Course Already Assigned");
            }
            return courseAssignGateway.Save(courseAssign)>0;
        }

        public bool IsCourseAlreadyAssigned(int courseId)
        {
            return courseAssignGateway.IsCourseAlreadyAssigned(courseId) > 0;
        }

    }
}
