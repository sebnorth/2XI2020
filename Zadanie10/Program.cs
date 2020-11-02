using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar kwadratu z gwiazdek: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j < n+1; j++) // j - numer wiersza
            {
                for (int i = 0; i < j; i++) // np. j=5, i=0,1,2,3,4 *****
                {
                    Console.Write("{0,4} ", j*(i+1));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
