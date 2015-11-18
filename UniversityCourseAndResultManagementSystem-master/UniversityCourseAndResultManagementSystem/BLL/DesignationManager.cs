using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    class DesignationManager
    {
        DesignationGateway designationGateway = new DesignationGateway();
        public List<Designation> GetAllDesignation()
        {
            return designationGateway.GetAllSemesters();
        }
    }
}
