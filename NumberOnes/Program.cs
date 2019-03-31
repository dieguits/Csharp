using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1, sum = 0;

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sum = sum + t;
                    Console.Write(t + " + ");
                    t = t * 10 + 1;
                }
                Console.Write("The sum is: " + sum);
            }

            Console.ReadKey();
        }
    }
}
