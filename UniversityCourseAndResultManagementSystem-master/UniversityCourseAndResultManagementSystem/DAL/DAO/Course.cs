namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
        public string Description { get; set; }
        public int Dept_id { get; set; }
        public int Semester_id { get; set; }

        public Course(string code, string name, decimal credit, string description, int deptId, int semesterId)
        {
            Code = code;
            Name = name;
            Credit = credit;
            Description = description;
            Dept_id = deptId;
            Semester_id = semesterId;
        }

        public Course()
        {
        }
    }
}