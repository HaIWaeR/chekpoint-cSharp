using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nИгра 1");
            Lotto loto1 = new Lotto();
            for (int i = 0; i < 50; i++)
            {
                int temporaryProvisioForInspection = loto1.GetNumber();
                Console.Write($"{temporaryProvisioForInspection} ");
                if (temporaryProvisioForInspection == -1)
                    break;
            }

            Console.WriteLine("\n\nИгра 2");
            Lotto loto2 = new Lotto();
            for (int i = 0; i < 50; i++)
            {
                int temporaryProvisioForInspection = loto2.GetNumber();
                Console.Write($"{temporaryProvisioForInspection} ");
                if (temporaryProvisioForInspection == -1)
                    break;
            }

            Console.WriteLine("\n\nИгра 3");
            Lotto loto3 = new Lotto();
            for (int i = 0; i < 50; i++)
            {
                int temporaryProvisioForInspection = loto3.GetNumber();
                Console.Write($"{temporaryProvisioForInspection} ");
                if (temporaryProvisioForInspection == -1)
                    break;
            }

            Console.WriteLine("\n\nИгра 4");
            Lotto loto4 = new Lotto();
            for (int i = 0; i < 50; i++)
            {
                int temporaryProvisioForInspection = loto4.GetNumber();
                Console.Write($"{temporaryProvisioForInspection} ");
                if (temporaryProvisioForInspection == -1)
                    break;
            }

            Console.WriteLine("\n\nИгра 5");
            Lotto loto5 = new Lotto();
            for (int i = 0; i < 110; i++)
            {
                int temporaryProvisioForInspection = loto5.GetNumber();
                Console.Write($"{temporaryProvisioForInspection} ");
                if (temporaryProvisioForInspection == -1)
                    break;
            }

            Lotto.PrintGamesStats();
        }
    }
}
