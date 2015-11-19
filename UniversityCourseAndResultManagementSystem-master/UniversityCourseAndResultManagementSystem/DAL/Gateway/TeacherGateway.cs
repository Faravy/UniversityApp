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
        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> teacherList = new List<Teacher>();
            string query = "SELECT * FROM t_teacher";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Id = (int)aSqlDataReader["id"];
                teacher.Name = aSqlDataReader["name"].ToString();
                teacher.Address = aSqlDataReader["address"].ToString();
                teacher.Email = aSqlDataReader["email"].ToString();
                teacher.Contact_No = aSqlDataReader["contact_no"].ToString();
                teacher.Designation_id =(int) aSqlDataReader["designation_id"];
                teacher.Department_id = (int)aSqlDataReader["department_id"];
                teacher.Credit_Taken = (double)aSqlDataReader["credit_taken"];


                teacherList.Add(teacher);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return teacherList;
        }


    }
}
