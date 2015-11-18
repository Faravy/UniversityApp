using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    class Designation
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public Designation(string name) : this()
        {

            Name = name;
        }

        public Designation()
        {

        }
    }
}
