using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_c__classes
{
    internal class Aspirant : Student
    {
        private string? ThesisTheme;


        public void DoInternShip()
        {
            Console.WriteLine("ШОСЬ ВИДБУВАЕТЬСЯ");
        }
        public void DefenfThesis()
        {
            Console.WriteLine("Теж шось происходит");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Тема диссертации: {ThesisTheme}");   // у меня нет других методов для студента, средний балл нет смысла переопределять
        }

    }
}
