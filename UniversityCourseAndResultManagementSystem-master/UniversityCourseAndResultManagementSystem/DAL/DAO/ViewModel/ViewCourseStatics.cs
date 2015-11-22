using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel
{
    public class ViewCourseStatics
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int DeptId { get; set; }
    }
}
