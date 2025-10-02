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

            Student studen1 = new Student("Виталий", "Папков", 5, "23.11.4");

            studen1.PrintInfo();


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
        public readonly string _firstName;
        public readonly string _lastName;
        public readonly double _averageGrade;
        public readonly string _className;
        public Student(string firstName, string lastName, double averageGrade, string className)
        {
            _firstName = firstName;
            _lastName = lastName;
            _averageGrade = averageGrade;
            _className = className;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ученик: {_firstName} {_lastName}, средняя оценка: " +
                $"{_averageGrade}, класс: {_className}");
        }
    }
}
