using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Janek = 50;
            int Karol = 40;
            int splata = 0;
            int dzien = 0;

            do
            {
                dzien += 1;
                splata += (int)(0.2 * Karol + 0.2 * Janek);
                Console.WriteLine("dzień nr: {0}, spłata łączna do tego dnia: {1}", dzien, splata);
            } while (splata < 80);



            Console.ReadKey();


        }
    }
}
