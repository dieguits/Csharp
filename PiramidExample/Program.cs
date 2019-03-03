using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramidExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string piramid = "";
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int y = 1; y <= 2*i-1; y++)
                {
                    if (y % 2 != 0)
                        Console.Write(y);
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
                piramid = "";
            }

            Console.ReadKey();
        }
    }
}
