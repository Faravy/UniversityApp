using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

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

        
    }
}