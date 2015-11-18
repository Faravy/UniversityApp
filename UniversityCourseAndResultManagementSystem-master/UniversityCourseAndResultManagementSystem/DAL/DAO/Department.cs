namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    public class Department
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }

        public Department(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {

        }

    }
}