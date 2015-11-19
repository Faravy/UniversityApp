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
    class CourseAssignGateway:Gateway
    {
        public int Save(CourseAssignToTeacher courseAssign)
        {
            string query = "INSERT INTO t_course_assign_to_teacher VALUES( '" + courseAssign.Teacher_id + "', '" + courseAssign.Course_id + "')";
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

        public List<TeacherCreditViewModel> GetTeacherAssignedCreditInfo()
        {
            string query = "SELECT * FROM V_Teacher_Description";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            List<TeacherCreditViewModel> teacherCreditViewModels = new List<TeacherCreditViewModel>();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader!=null)
            {
                while (aSqlDataReader.Read())
                {
                    TeacherCreditViewModel creditViewModel  = new TeacherCreditViewModel();
                    creditViewModel.TeacherId = int.Parse(aSqlDataReader["TeacherID"].ToString());
                    creditViewModel.CreditToBeTaken = double.Parse(aSqlDataReader["CreditToBeTaken"].ToString());
                    creditViewModel.CreditAssigned = double.Parse(aSqlDataReader["CreaditTaken"].ToString());
                    teacherCreditViewModels.Add(creditViewModel);
                }
               aSqlDataReader.Close();
               aSqlConnection.Close();
            }
            return teacherCreditViewModels;

        }
    }
}
