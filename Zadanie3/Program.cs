using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumujemy kolejne liczby naturalne - wersja z FOR");
            int s = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                // i++;
                Console.WriteLine("Po {0}-tej iteracji wartość sumy wynosi: {1}", i, s);
            }

            Console.WriteLine("Suma końcowa: {0}", s);

            Console.ReadKey();
        }
    }
}
