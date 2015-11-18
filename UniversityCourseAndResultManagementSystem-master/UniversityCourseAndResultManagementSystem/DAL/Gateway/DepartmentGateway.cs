using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class DepartmentGateway : Gateway
    {
        public void Save(Department aDepartment)
        {
            string query = "INSERT INTO t_department VALUES('" + aDepartment.Code + "', '" + aDepartment.Name + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Department FindCode(string code)
        {
            string query = "SELECT * FROM t_department WHERE code='" + code + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            Department aDepartment;

            if (aSqlDataReader.HasRows)
            {
                aDepartment = new Department();
                aSqlDataReader.Read();
                aDepartment.Id = (int)aSqlDataReader["id"];
                aDepartment.Code = aSqlDataReader["code"].ToString();
                aDepartment.Name = aSqlDataReader["name"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aDepartment;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }
        public Department FindName(string name)
        {
            string query = "SELECT * FROM t_department WHERE name='" + name + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            Department aDepartment;

            if (aSqlDataReader.HasRows)
            {
                aDepartment = new Department();
                aSqlDataReader.Read();
                aDepartment.Id = (int)aSqlDataReader["id"];
                aDepartment.Code = aSqlDataReader["code"].ToString();
                aDepartment.Name = aSqlDataReader["name"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aDepartment;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departmentList = new List<Department>();
            string query = "SELECT * FROM t_department";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = (int)aSqlDataReader["id"];
                aDepartment.Code = aSqlDataReader["code"].ToString();
                aDepartment.Name = aSqlDataReader["name"].ToString();

                departmentList.Add(aDepartment);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return departmentList;
        }

    }
}