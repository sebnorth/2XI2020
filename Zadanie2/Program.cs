using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sumujemy kolejne liczby naturalne - wersja z FOR");
            int s = 0;


            for (int i = 1; i <= 10;)
            {
                s = s + i;
                i++;
                Console.WriteLine("Po {0}-tej iteracji wartość sumy wynosi: {1}", i, s);
            }

            Console.WriteLine("Suma końcowa: {0}", s);

            Console.ReadKey();
        }
    }
}
