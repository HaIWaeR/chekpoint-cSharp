using System;
using System.Runtime.InteropServices;

namespace SchoolCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание студентов 
            Student person1 = new Student("Виталий", "Папков", 3.5, "ИТ-11.24.3");
            Student person2 = new Student("Юрий", "Сакутин", 4.8, "ИТ-11.24.3");
            Student person3 = new Student("Дон", "Хоссе", 2.6, "ИТ-11.24.3");

            Student person4 = new Student("Дарьяна", "Джус", 3.2, "ФТ-11.24.2");
            Student person5 = new Student("Морген", "Штерн", 2.9, "ФТ-11.24.2");
            Student person6 = new Student("Биг", "Рашенбос", 3.1, "ФТ-11.24.2");

            Student person7 = new Student("Эльдар", "Джарахов", 9.1, "ЛИТ-09.21.2");
            Student person8 = new Student("Биба", "Бобович", 8.7, "ЛИТ-09.21.2");
            Student person9 = new Student("Строфа", "Поэмова", 9.4, "ЛИТ-09.21.2");

            // Создание двух двух школ, номером 55 и 121
            School school_55 = new School();
            School school_121 = new School();

            // Зачисление студентов в школы
            school_55.EnrollStudent(person1);
            school_55.EnrollStudent(person2);
            school_55.EnrollStudent(person3);

            school_55.EnrollStudent(person4);
            school_55.EnrollStudent(person5);
            school_55.EnrollStudent(person6);

            school_55.EnrollStudent(person7);
            school_55.EnrollStudent(person8);
            school_55.EnrollStudent(person9);

            // Вывод студентво из определённого класса
            school_55.PrintClassInfo("ИТ-11.24.3");
            school_55.PrintClassInfo("ЛИТ-09.21.2");

            // Вывод данных определённого студента 
            person1.printInfo();
            person4.printInfo();
            person7.printInfo();
            person8.printInfo();

        }
    }

}


