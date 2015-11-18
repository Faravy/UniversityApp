using System.Collections.Generic;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {

            if (aDepartment.Code.Length >= 2 && aDepartment.Code.Length <= 7)
            {
                Department departmentForCodeCheck = aDepartmentGateway.FindCode(aDepartment.Code);
                Department departmentForNameCheck = aDepartmentGateway.FindName(aDepartment.Name);

                if (departmentForCodeCheck == null && departmentForNameCheck==null)
                {
                    aDepartmentGateway.Save(aDepartment);
                    return "Department added.";
                }
                else
                {
                    return "Department CODE already exists.";
                }

            }
            else
            {
                return "Code length must be 2 to 7 characters long.";
            }
        }

        public List<Department> GetAllDepartments()
        {
            return aDepartmentGateway.GetAllDepartments();
        }

        
    }
}