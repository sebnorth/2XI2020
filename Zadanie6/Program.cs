﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar kwadratu z gwiazdek: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
