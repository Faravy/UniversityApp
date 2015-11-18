using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class DesignationGateway:Gateway
    {
        public List<Designation> GetAllSemesters()
        {
            List<Designation> designationList = new List<Designation>();
            string query = "SELECT * FROM t_designation";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Designation adesignation = new Designation();
                adesignation.Id = (int)aSqlDataReader["id"];
                adesignation.Name = aSqlDataReader["name"].ToString();

                designationList.Add(adesignation);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return designationList;
        }
    }
}
