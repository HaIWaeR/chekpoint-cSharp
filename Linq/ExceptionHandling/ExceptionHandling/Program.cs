using System;
using System.Drawing;
using System.Globalization;
using System.Threading.Channels;

namespace EceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persone persone1 = new Persone(2, "Tom");
        }
    }


    class Persone
    {
        private int age;
        public string Name { get; set; }

        

        public Persone(int age, string name)
        {
            this.Age = age;
            Name = name;

        }

        public int Age
        {

            get => age;
            set
            {
                if (value < 18)
                    throw new Exception("пиздюк");
                else
                    age = value;
            }
        }
    }
}