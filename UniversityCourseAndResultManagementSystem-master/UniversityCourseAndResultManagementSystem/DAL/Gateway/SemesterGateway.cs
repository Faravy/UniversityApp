using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    public class SemesterGateway:Gateway
    {
        public List<Semester> GetAllSemesters()
        {
            List<Semester> semesterList = new List<Semester>();
            string query = "SELECT * FROM t_semester";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Semester aSemester = new Semester();
                aSemester.Id = (int)aSqlDataReader["id"];
                aSemester.Name = aSqlDataReader["name"].ToString();

                semesterList.Add(aSemester);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return semesterList;
        }
    }
}