using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0) Console.WriteLine("Liczba {1} jest dzielnikiem liczby {0}.", a, b);
            else Console.WriteLine("Liczba {1} NIE jest dzielnikiem liczby {0}.", a, b);

            // Liczba 2 jest dzielnikiem liczby 12.

            Console.Write("Dzielniki liczby {0}: ", a);

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0) Console.Write("{0} ",i);
            }

            Console.ReadKey();
        }
    }
}
