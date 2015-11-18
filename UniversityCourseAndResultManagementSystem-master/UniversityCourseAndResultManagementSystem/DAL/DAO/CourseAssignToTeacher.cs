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
        public int Department_id { get; set; }
        public int Teacher_id { get; set; }
        public int Course_id { get; set; }
        public Department department;
        public Teacher teacher;
        public Course course;

        public CourseAssignToTeacher(Department department, Teacher teacher, Course course, int departmentId, int teacherId, int courseId)
        {
            this.department = department;
            this.teacher = teacher;
            this.course = course;
            Department_id = departmentId;
            Teacher_id = teacherId;
            Course_id = courseId;
        }

        public CourseAssignToTeacher()
        {
        }
    }
}
