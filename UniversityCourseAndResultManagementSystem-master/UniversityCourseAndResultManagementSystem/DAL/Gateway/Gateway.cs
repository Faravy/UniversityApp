using System.Configuration;
using System.Data.SqlClient;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    public class Gateway
    {
        public string connectionString = @"server=VAGABOND\SQLEXPRESS; Integrated Security = SSPI; 		database = UniversityApp";
        public SqlConnection aSqlConnection;
        public SqlCommand aSqlCommand;

        public Gateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
    }
}