using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCollection
{
    internal class School
    {
        private Dictionary<string, List<Student>> _classes = new Dictionary<string, List<Student>>();

        public void EnrollStudent(Student student)
        {
            string className = student._class;
            
            if (!_classes.ContainsKey(className))
            {
                _classes[className] = new List<Student>();
            }
            
            _classes[className].Add(student);
        }
        public void PrintClassInfo(string @class)
        {
            foreach (Student student in _classes[@class])
            {
                student.printInfo();
            }
        }


    }
}
