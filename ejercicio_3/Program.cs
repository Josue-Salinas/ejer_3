﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int año_actual = 2023;

                Console.WriteLine("Años bisiestos desde 1900 hasta el año actual:");
                for (int año = 1900; año <= año_actual; año++)
                {
                    if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    {
                        Console.WriteLine(año);
                    }
                }
                Console.ReadKey();
            }
        }

    }
}

