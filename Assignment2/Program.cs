using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serie the primes number using neested loops.
            int times = 0;
            string output = "";

            for (int i = 2; i <= 50; i++)
            {
                times = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        times++;
                    }

                    if (times > 2)
                    {
                        break;
                    }

                }

                if (times == 2)
                {
                    if (output == "")
                    {
                        output += i;
                    }
                    else
                    {
                        output += " " + i;
                    }
                }
            }

            Console.WriteLine("The prime number between 1 and 50 are:");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
