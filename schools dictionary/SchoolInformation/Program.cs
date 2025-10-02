using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Student vasi = new Student("Виталий", "Папков", 5, "23.11.4");

            vasi.PrintInfo();
        }
    }


    class School
    {
        public void EnrollStudent()
        {

        }

        public void PrintClassInfo()
        {

        }

    }

    class Student
    {
        public string FirstName;
        public string LastName;
        public double AverageGrade;
        public string Class;
        public Student(string firstName, string lastName, double averageGrade, string studentClass)
        {
            FirstName = firstName;
            LastName = lastName;
            AverageGrade = averageGrade;
            Class = studentClass;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ученик: {FirstName} {LastName}, средняя оценка: " +
                $"{AverageGrade}, класс: {Class}");
        }
    }



}
