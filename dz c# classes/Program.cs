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
        }
    }
}
