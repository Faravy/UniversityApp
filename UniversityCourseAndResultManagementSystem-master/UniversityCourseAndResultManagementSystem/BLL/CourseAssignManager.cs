using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel;
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

        private List<TeacherCreditViewModel> GetTeacherAssignedCreditInfo()
        {
            return courseAssignGateway.GetTeacherAssignedCreditInfo();
        }

        public double GetTeacherRemainingCreditByTeacherId(int teacherId)
        {
            double creditAssigned = 0;
            List<TeacherCreditViewModel> creditViewModels = GetTeacherAssignedCreditInfo();
            if (creditViewModels != null && creditViewModels.Any())
            {
                TeacherCreditViewModel creditViewModel = creditViewModels.FirstOrDefault(c => c.TeacherId == teacherId);
                if (creditViewModel!=null)
                {
                    creditAssigned = creditViewModel.CreditAssigned;
                }
            }
            return creditAssigned;
        }

    }
}
