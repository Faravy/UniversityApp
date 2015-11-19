using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    class CourseAssignToTeacher
    {
        public int Id { get; set; }
        public int Teacher_id { get; set; }
        public int Course_id { get; set; }
        public Department Department { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

        public CourseAssignToTeacher( int teacherId, int courseId, Department department, Teacher teacher, Course course)
        {
            Teacher_id = teacherId;
            Course_id = courseId;
            Department = department;
            Teacher = teacher;
            Course = course;
        }

        public CourseAssignToTeacher()
        {
        }
    }
}
