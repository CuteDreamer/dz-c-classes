namespace dz_c__classes
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Student Artem = new Student("Artem", "Karp", "Vladimirovich", "1991", "Odessa", "samsung");

            Artem.AddCredit(12);
            Artem.AddCoursework(12);
            Artem.AddExam(12);
            Artem.ShowInfo();

            Group mygroup = new Group("PV312", "Software engeneer", 1);
            mygroup.SetGroupName("TEST");
            Console.WriteLine(mygroup.GetGroupName());


            Student Test = new Student("Test", "Testov", "Testovich", "testing", "Test", "tested");
            mygroup.AddStudent(Artem);
            mygroup.AddStudent(Test);

            mygroup.ShowAllStudents();


            List<Student> students = new List<Student>();

            Student.Sort(students, new Student.SortByName());
            Student.Sort(students, new Student.SortByDate());

        }

    }
}
