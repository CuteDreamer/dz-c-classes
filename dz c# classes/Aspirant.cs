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


        public Aspirant() : base()
        {
            SetThesisTheme("Тема диссертации по умолчанию");
        }

        public Aspirant(string? name) : base(name)
        {
            SetThesisTheme("Тема диссертации по умолчанию");
        }

        public Aspirant(string? name, string? lastname) : base(name, lastname)
        {
            SetThesisTheme("Тема диссертации по умолчанию");
        }

        public Aspirant(string? name, string? lastname, string? patron) : base(name, lastname, patron)
        {
            SetThesisTheme("Тема диссертации по умолчанию");
        }

        public Aspirant(string? name, string? lastname, string? patron, string? date, string? address, string? phone, string? ThesisTheme) : base(name, lastname, patron, date, address, phone)
        {
            SetThesisTheme(ThesisTheme);
        }

        public void SetThesisTheme(string? ThesisTheme)
        {
            this.ThesisTheme = ThesisTheme;
        }
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
