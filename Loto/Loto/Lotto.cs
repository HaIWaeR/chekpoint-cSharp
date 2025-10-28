using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        private readonly List<int> _lossHistory = new List<int>();
        private static Random rnd = new Random();
        public readonly int _numberOfGames = 99;
        private static Dictionary<int, int> numberStatistics = new Dictionary<int, int>();

        public int GetNumber()
        {
            if (_lossHistory.Count >= _numberOfGames)
            {
                Console.Write("\nВ диапазоне нехватает чисел: ");
                return -1;
            }

            int returnNumber;

            do
            {
                returnNumber = rnd.Next(1, 100);
            }
            while (_lossHistory.Contains(returnNumber));
            _lossHistory.Add(returnNumber);

            if (numberStatistics.ContainsKey(returnNumber))
                numberStatistics[returnNumber]++;
            else
                numberStatistics[returnNumber] = 1;
            return returnNumber;
        }
        public static void PrintGamesStats()
        {
            if (numberStatistics.Count == 0)
            {
                Console.WriteLine("Числа еще не выпадали");
                return;
            }   

            List<int> sortedKeys = new List<int>(numberStatistics.Keys);
            sortedKeys.Sort();

            Console.WriteLine();
            foreach (int key in sortedKeys)
            {
                Console.WriteLine($"Число {key}: выпало {numberStatistics[key]} раз");
            }
        }
    }
}
