using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program oblicza sumę 1+2+... + 10;
            
            int i = 1;
            int s = 0;

            while (i<=10)
            {
                s += i;
                i++;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
