using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class StudentGateway:Gateway
    {
        public int Save(Student student)
        {
            string query = "INSERT INTO t_student VALUES('" + student.Name + "', '" + student.Email + "', '" + student.ContactNo + "', '" + student.Date + "', '" + student.Address + "', '"  + student.DeptId + "','"+ student.RegNo +"')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            int rowAffected = aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            return rowAffected;
        }
        public int IsEmailAlreadyExist(string email)
        {
            string query = "SELECT * FROM t_student WHERE email='" + email + "'";
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
        public List<Student> GetAllStudents()
        {
            string query = "SELECT * FROM t_student";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            List<Student> studentList = new List<Student>();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader != null)
            {
                while (aSqlDataReader.Read())
                {
                    Student student = new Student();
                    student.Name = aSqlDataReader["name"].ToString();
                    student.Email = aSqlDataReader["email"].ToString();
                    student.ContactNo = aSqlDataReader["contact_no"].ToString();
                    student.Date = (DateTime) aSqlDataReader["date"];
                    student.Address = aSqlDataReader["address"].ToString();
                    student.DeptId =(int) aSqlDataReader["dept_id"];
                    student.RegNo = aSqlDataReader["reg_no"].ToString();
                    studentList.Add(student);
                }
                aSqlDataReader.Close();
                aSqlConnection.Close();
            }
            return studentList;

        }
    }
}
