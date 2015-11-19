using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel
{
    public class TeacherCreditViewModel
    {
        public int  TeacherId { get; set; }
        public double CreditToBeTaken { get; set; }
        public double CreditAssigned { get; set; }

    }
}
