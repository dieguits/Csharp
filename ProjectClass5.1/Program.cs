using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop 200 + 190 + 180 + ... + 160 when iteration = 10
            int i = 0;
            int sum = 200;
            int iter = 0;

            for (i = 190; i >= 100; i -= 10)
            {
                sum += i;
                iter++;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("i: " + i);
            Console.WriteLine("Iterations: " + iter);
            Console.WriteLine("----------------------------------");
            //loop while
            int j = 190;
            int suma = 200;
            int itera = 0;

            while (j >= 100)
            {
                suma += j;
                j -= 10;
                itera++;
            }

            Console.WriteLine("Sum: " + suma);
            Console.WriteLine("j: " + j);
            Console.WriteLine("iteration: " + itera);
            Console.WriteLine("----------------------------------");
            //loop Do-while
            int x = 190;
            int sumy = 200;
            int iterac = 0;

            do
            {
                sumy += x;
                x -= 10;
                iterac++;

            } while (x >= 100);

            Console.WriteLine("Sum: " + sumy);
            Console.WriteLine("x: " + x);
            Console.WriteLine("iteraction: " + iterac);

            Console.ReadKey();
        }
    }
}
