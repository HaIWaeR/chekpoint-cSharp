using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver firstCar = new Driver(60, 1000);

            // 1000 км
            firstCar.PrintLocation();

            // 1360 км
            firstCar.Drive(6);
            firstCar.PrintLocation();

            // 1180 км
            firstCar.DriveBack(3);
            firstCar.PrintLocation();

            // Вы в горде №2
            firstCar.Drive(40);
            firstCar.PrintLocation();
        }
    }
}
