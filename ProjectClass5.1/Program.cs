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

            for (i = 190; i >= 100; i-=10)
            {
                sum += i;
                iter++;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("i: " + i);
            Console.WriteLine("Iterations: " + iter);

            Console.ReadKey();
        }
    }
}
