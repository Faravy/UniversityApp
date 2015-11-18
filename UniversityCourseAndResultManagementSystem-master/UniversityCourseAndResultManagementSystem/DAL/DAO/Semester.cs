namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    public class Semester
    {
        public int Id { set; get; }
       
        public string Name { set; get; }

        public Semester(string name) : this()
        {
           
            Name = name;
        }

        public Semester()
        {

        }
    }
}