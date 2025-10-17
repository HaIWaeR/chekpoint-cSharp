using System;
using System.Collections.Generic;
using System.Globalization;
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


            School OneTwoOne = new School();
            OneTwoOne.EnrollStudent(studen1);

        }
    }


    class School
    {
        public readonly Dictionary<string, List<Student>> _listOfStudents = new Dictionary<string, List<Student>>();

        public void EnrollStudent(Student student)
        {
            if (_listOfStudents.ContainsKey(student._className))
            {
                    _listOfStudents[student._className].Add(student);
            }
        }   

        public void PrintClassInfo(string className)
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

            Console.WriteLine($"Ученик: {_firstName ?? "Нет данных"} {_lastName ?? "Нет данных"}, " +
            $"средняя оценка: {_averageGrade}, класс: {_className ?? "Нет данных"}");
        }
    }
}
