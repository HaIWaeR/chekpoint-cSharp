using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCollection
{
    internal class Student
    {
        public readonly string _name;
        public readonly string _lastName;
        public readonly double _averageGrade;
        public readonly string _class;

        public Student(string name, string lastName, double averageGrade, string @class)
        {
            _name = name;
            _lastName = lastName;
            _averageGrade = averageGrade;
            _class = @class;
        }
        public void printInfo()
        {
            Console.WriteLine($"Ученик {_name} {_lastName} средняя оценка " +
                $"{_averageGrade} Класс {_class}");
        }

    }
}
