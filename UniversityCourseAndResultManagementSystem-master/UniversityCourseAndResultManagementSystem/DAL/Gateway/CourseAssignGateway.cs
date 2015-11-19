using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class CourseAssignGateway:Gateway
    {
        public int Save(CourseAssignToTeacher courseAssign)
        {
            string query = "INSERT INTO t_course_assign_to_teacher VALUES('" + courseAssign.Department_id + "', '" + courseAssign.Teacher_id + "', '" + courseAssign.Course_id + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            int rowAffected =  aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            return rowAffected;
        }
        public int IsCourseAlreadyAssigned(int courseId)
        {
            string query = "SELECT * FROM t_course_assign_to_teacher WHERE course_id='" + courseId + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            
            if (aSqlDataReader.HasRows)
            {               
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return 1;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return -1;
            }
        }
    }
}
