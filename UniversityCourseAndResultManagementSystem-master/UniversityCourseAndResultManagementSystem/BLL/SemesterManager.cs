using System.Collections.Generic;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    public class SemesterManager
    {
        SemesterGateway aSemesterGateway=new SemesterGateway();
        public List<Semester> GetAllSemesters()
        {
            return aSemesterGateway.GetAllSemesters();
        }
    }
}