using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 + x + x^2 / 2 + x^3/3

            int n = 4;
            int x = 2;
            double result = 1 + x;

            for (int i = 2; i <= n; i++)
            {
                result = result + Math.Pow(x, i) / i;
            }

            Console.WriteLine("Result is: " + result);
            Console.ReadKey();
        }
    }
}
