namespace SingleResponsability
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public List<double> Grades { get; set; }

        //Dos constructores, uno que recibe parametros y otro que no

        public Student()
        {
            this.Fullname = string.Empty;
            this.Grades = new List<double>();
        }

        public Student(int id, string fullname, List<double> grades)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Grades = grades;
        }
    }
}