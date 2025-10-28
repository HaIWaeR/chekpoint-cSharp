using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drive
{
    internal class Driver
    {
        readonly private int AverageСarSpeed;
        private int CarСoordinate;
        private double TechnicalCondition = 100;
        
        private readonly int _startСityN1 = 1010;
        private readonly int _endСityN1 = 1020;

        private readonly int _startСityN2 = 3565;
        private readonly int _endСityN2 = 3580;

        private readonly int _startСityN3 = -2500;
        private readonly int _endСityN3 = -2530;

        public Driver(int averageСarSpeed, int carСoordinate)
        {
            AverageСarSpeed = averageСarSpeed;
            CarСoordinate = carСoordinate;
        }
        public void Drive(int travelTime)
        {
            if (TechnicalCondition > 0)
            {
                CarСoordinate += travelTime * AverageСarSpeed;
                TechnicalCondition += -0.01 * ((AverageСarSpeed * travelTime) / 100);
            }
            else
               Console.WriteLine("Машина мертва!");
        }

        public void DriveBack(int travelTime)
        {
            if (TechnicalCondition > 0)
            {
                CarСoordinate -= travelTime * AverageСarSpeed;
                TechnicalCondition += -0.01 * ((AverageСarSpeed * travelTime) / 100);
            }
            else
                Console.WriteLine("Машина мертва!");
        }

        public void PrintLocation()
        {
            Console.WriteLine();
            if (CarСoordinate >= _startСityN1 && CarСoordinate <= _endСityN1)
            {
                Console.WriteLine("Вы в городе N1");
                return;
            }

            if (CarСoordinate >= _startСityN2 && CarСoordinate <= _endСityN2)
            {
                Console.WriteLine("Вы в городе N2");
                return;
            }

            if (CarСoordinate >= _startСityN3 && CarСoordinate <= _endСityN3)
            {
                Console.WriteLine("Вы в городе N3");
                return;
            }
            Console.WriteLine($"Вы находитесь на трассе на {CarСoordinate} километре ");
            Console.WriteLine();
        }
    }
}
