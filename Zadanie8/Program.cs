using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Program wypisuje kolejne wielokrotności liczby 7
            Console.WriteLine("Podaj wartość zmiennej ile: ");
            int ile = int.Parse(Console.ReadLine());

            //for (int i = 0; i < ile; i++)
            //{
            //    Console.Write("{0} ", 7*i);

            //}

            int wielokrotnośćSiodemki = 0;
            int i = 1;

            while (i++ <= ile)
            {
                Console.Write("{0} ", wielokrotnośćSiodemki);
                wielokrotnośćSiodemki += 7;
                // i++;
            }

            Console.ReadKey();

        }
    }
}
