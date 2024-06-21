using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_c__classes
{
    internal class Group
    {
        private List<Student> students = new List<Student>();
        private string? groupname;
        private string? groupspecialization;
        private int coursenumber;

        public Group()
        {

        }
        public Group(string? groupname, string? groupspecialization, int coursenumber)
        {
            SetGroupName(groupname);
            SetGroupSpecialization(groupspecialization);
            SetCourseNumber(coursenumber);
        }

        public void SetGroupName(string? groupname)
        {
            this.groupname = groupname;
        }
        public void SetCourseNumber(int coursenumber)
        {
            this.coursenumber = coursenumber;
        }
        public void SetGroupSpecialization(string? groupspecialization)
        {
            this.groupspecialization = groupspecialization;
        }


        public string? GetGroupName()
        {
            return groupname;
        }
        public string? GetGroupSpecialization()
        {
            return groupspecialization;
        }
        public int GetCourseNumber()
        {
            return coursenumber;
        }

        public string? Groupname
        {
            get { return groupname; }
            set { groupname = value; }
        }
        public string? GroupSpecialization
        {
            get { return groupspecialization; }
            set { groupspecialization = value; }
        }
        public int Coursenumber
        {
            get { return coursenumber; }
            set { coursenumber = value; }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("Все студенты:");              // здесь не foreach потому что номер студента нам тоже нужен порядковый 
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("Номер студента " + (i + 1));  // ну не с 0 он будет начинаться)))))
                Console.WriteLine(GetGroupName());
                Console.WriteLine(GetGroupSpecialization());
                Console.WriteLine(GetCourseNumber());
                students[i].ShowInfo();
            }
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void TransferStudent(Student student, Group newgroup)
        {
            students.Remove(student);
            newgroup.AddStudent(student);                             // наверное так будет. типа из листа в одном экземпляре удалили, в новый экземпляр в лист добавили
        }

        public void KickStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("В группе некого больше отчислять))))");
            }

            Student lowestscoringstudent = students[0];
            double lowestaveragescore = students[0].GetAverageScore();

            foreach (var student in students)
            {
                double averagescore = student.GetAverageScore();
                if (averagescore < lowestaveragescore)
                {
                    lowestscoringstudent = student;
                    lowestaveragescore = averagescore;
                }
            }
            students.Remove(lowestscoringstudent);

            Console.WriteLine("Самый слабый изгнан!!! Теперь миром правит жируха. Покайтесь! Иначе она вас сожрёт :D");
        }

        public double GetGroupAverageScore()           // вычисляем средний балл у группы
        {
            if (students.Count == 0)
            {
                return 0;
            }

            double totalScore = 0;

            foreach (var student in students)
            {
                totalScore += student.GetAverageScore();
            }

            return totalScore / students.Count;
        }

        public static bool operator ==(Group g1, Group g2)  // ничего более умного не пришло в голову мне
        {
            return g1.GetGroupAverageScore() == g2.GetGroupAverageScore();
        }

        public static bool operator !=(Group g1, Group g2)
        {
            return !(g1 == g2);
        }
    }
}
