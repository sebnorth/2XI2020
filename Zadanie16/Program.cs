using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            // program oblicza 2+4+6+8+10+12+14+16+18+20 = (2+20)/2 * 10.
            
            int i = 1;
            int j = 2;
            int s = 0;

            while (i<=10)
            {

                s = s + j;
                j = j + 2;
                i = i + 1;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
