﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass2
{
    class Program
    {
        enum Colors
        {
            Red = 654356,
            Blue = 345687
        }

        static void Main(string[] args)
        {
            /*
            int a = 10;
            int b = 20;
            int result;
            result = a + b;
            */

            /*
            float a = 20.5f;
            float b = 12.35f;
            float result;
            result = a * b;
            Console.WriteLine("The result is: " + result);
             */

            int a = 10;
            a++;
            Console.WriteLine(a);
            a += 5;
            Console.WriteLine(a);
            a += 3;
            Console.WriteLine(a);

            string quantityString = String.Format("{0:n3}", 150003.9); //15,000

            Console.WriteLine("This is the result: " + quantityString + Colors.Blue);

          

            Console.ReadKey();

        }
    }
}
