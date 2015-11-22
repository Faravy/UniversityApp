using System.Collections.Generic;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    public class CourseManager
    {
        CourseGateway aCourseGateway = new CourseGateway();
        public string Save(Course aCourse)
        {

            if (aCourse.Code.Length >= 5)
            {
                if (aCourse.Credit >= (decimal) .5 && aCourse.Credit <= 5)
                {
                    Course courseForCodeCheck = aCourseGateway.FindCode(aCourse.Code);
                    Course courseForNameCheck = aCourseGateway.FindName(aCourse.Name);

                    if (courseForCodeCheck == null)
                    {
                        if (courseForNameCheck == null)
                        {
                            aCourseGateway.Save(aCourse);
                            return "Course added.";
                        }
                        else
                        {
                            return "Course Name already exists.";
                        }
                        
                    }
                    else
                    {
                        return "Course CODE already exists.";
                    }
                }
                else
                {
                    return "Credit cannot be less than 0.5 and more than 5.0";
                }

            }
            else
            {
                return "Code length must be 5 characters long.";
            }
        }
        public List<Course> GetAllCourse()
        {
            return aCourseGateway.GetAllCourse();
        }
        public List<ViewCourseStatics> GetAssignCourses()
        {
            return aCourseGateway.GetAssignedCourse();
        }

    }
}