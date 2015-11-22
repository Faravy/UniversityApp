using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    public class CourseGateway:Gateway
    {
        public void Save(Course aCourse)
        {
            string query = "INSERT INTO t_course VALUES('" + aCourse.Code + "', '" + aCourse.Name + "', '" + aCourse.Credit + "', '" + aCourse.Description + "', '" + aCourse.Dept_id + "', '" + aCourse.Semester_id + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Course FindCode(string code)
        {
            string query = "SELECT * FROM t_course WHERE code='" + code + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            Course aCourse;

            if (aSqlDataReader.HasRows)
            {
                aCourse = new Course();
                aSqlDataReader.Read();
                aCourse.Code = aSqlDataReader["code"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aCourse;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }
        public Course FindName(string name)
        {
            string query = "SELECT * FROM t_course WHERE code='" + name + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            Course aCourse;

            if (aSqlDataReader.HasRows)
            {
                aCourse = new Course();
                aSqlDataReader.Read();
                aCourse.Name = aSqlDataReader["name"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aCourse;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public List<Course> GetAllCourse()
        {
            List<Course> courseList = new List<Course>();
            string query = "SELECT * FROM t_course";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Course course = new Course();
                course.Id = (int)aSqlDataReader["id"];
                course.Name = aSqlDataReader["name"].ToString();
                course.Code = aSqlDataReader["code"].ToString();
                course.Credit =(decimal) aSqlDataReader["credit"];
                course.Description = aSqlDataReader["description"].ToString();
                course.Dept_id = (int)aSqlDataReader["dept_id"];
                course.Semester_id = (int)aSqlDataReader["semester_id"];
                


                courseList.Add(course);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return courseList;
        }
        public List<ViewCourseStatics> GetAssignedCourse()
        {
            List<ViewCourseStatics> courseList = new List<ViewCourseStatics>();
            string query = "SELECT * FROM View_CourseStatics";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                ViewCourseStatics viewCourseStatics = new ViewCourseStatics();

                viewCourseStatics.CourseId= (int)aSqlDataReader["CourseId"];
                viewCourseStatics.CourseCode = aSqlDataReader["CourseCode"].ToString();
                viewCourseStatics.CourseName = aSqlDataReader["CourseName"].ToString();
                viewCourseStatics.SemesterName = aSqlDataReader["Semester"].ToString();
                viewCourseStatics.TeacherName = aSqlDataReader["TeacherName"].ToString();
                viewCourseStatics.DeptId = (int)aSqlDataReader["DeptId"];

                courseList.Add(viewCourseStatics);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return courseList;
        }



    }
}