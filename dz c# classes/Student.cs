﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_c__classes
{
    internal class Student
    {
        private string? name;
        private string? lastname;
        private string? patron;
        private string? date;
        private string? address;
        private string? phone;
        private List<int> credits = new List<int>();
        private List<int> courseworks = new List<int>();
        private List<int> exams = new List<int>();

        public Student() : this("default", "deafoltov", "deafoltovich", "01.01.01", "North Korea", "haven't")
        {

        }
        public Student(string? name) : this(name, "Karp", "Vladimirovich", "05.09.91", "null", "null")
        {

        }
        public Student(string? name, string? lastname) : this(name, lastname, "Vladimirovich", "05.09.91", "null", "null")
        {

        }
        public Student(string? name, string? lastname, string? patron) : this(name, lastname, patron, "05.09.91", "null", "null")
        {

        }

        public Student(string? name, string? lastname, string? patron, string? date, string? address, string? phone)
        {
            SetName(name);
            SetLastName(lastname);
            SetPatron(patron);
            SetDate(date);
            SetAddress(address);
            SetPhone(phone);
        }


        public void SetName(string? name)
        {
            this.name = name;
        }
        public void SetLastName(string? lastname)
        {
            this.lastname = lastname;
        }
        public void SetPatron(string? patron)
        {
            this.patron = patron;
        }
        public void SetDate(string? date)
        {
            this.date = date;
        }
        public void SetAddress(string? address)
        {
            this.address = address;
        }
        public void SetPhone(string? phone)
        {
            this.phone = phone;
        }


        public string? GetName()
        {
            return name;
        }
        public string? GetLastName()
        {
            return lastname;
        }
        public string? GetPatron()
        {
            return patron;
        }
        public string? GetDate()
        {
            return date;
        }
        public string? GetAddress()
        {
            return address;
        }
        public string? GetPhone()
        {
            return phone;
        }

        public void AddCredit(int credit)
        {
            credits.Add(credit);
        }

        public void AddCoursework(int coursework)
        {
            courseworks.Add(coursework);
        }

        public void AddExam(int exam)
        {
            exams.Add(exam);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Фамилия: {GetLastName()}");
            Console.WriteLine($"Отчество: {GetPatron()}");
            Console.WriteLine($"Дата рождения: {GetDate()}");
            Console.WriteLine($"Адрес: {GetAddress()}");
            Console.WriteLine($"Телефон: {GetPhone()}");

            Console.WriteLine("Оценки студента:");
            foreach (var credit in credits)
            {
                Console.WriteLine(credit);
            }

            Console.WriteLine("Курсовые работы студента:");
            foreach (var coursework in courseworks)
            {
                Console.WriteLine(coursework);
            }

            Console.WriteLine("Экзамены студента:");
            foreach (var exam in exams)
            {
                Console.WriteLine(exam);
            }
        }
    }
}