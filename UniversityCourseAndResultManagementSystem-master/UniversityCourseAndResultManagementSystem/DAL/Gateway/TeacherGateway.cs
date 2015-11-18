using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class TeacherGateway : Gateway
    {

        public void Save(Teacher atTeacher)
        {
            string query = "INSERT INTO t_teacher VALUES('" + atTeacher.Name + "', '" + atTeacher.Address + "', '" + atTeacher.Email + "', '" + atTeacher.Contact_No + "', '" + atTeacher.Designation_id + "', '" + atTeacher.Department_id + "','" + atTeacher.Credit_Taken + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Teacher FindEmail(string email)
        {
            string query = "SELECT * FROM t_teacher WHERE email='" + email + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            Teacher aTeacher;

            if (aSqlDataReader.HasRows)
            {
                aTeacher = new Teacher();
                aSqlDataReader.Read();
                aTeacher.Email = aSqlDataReader["email"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aTeacher;
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
