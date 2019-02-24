using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 5;
            int i = 0;

            //for loop
            //5 + 10 + 15 + 20 + 25
            for (i = 10; i <= 25; i+=5)
            {
                sum += i;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("i: " + i);

            int sum2 = 5;
            int i2 = 10;

            //While loop
            while (i2 <= 25)
            {
                sum2 += i2;
                i2 += 5;
            }

            Console.WriteLine("Sum: " + sum2);
            Console.WriteLine("i: " + i2);

            //Do while
            int sum3 = 5;
            int i3 = 10;
            do
            {
                sum3 += i3;
                i3 += 5;
            } while (i3 <= 25);

            Console.WriteLine("Sum: " + sum3);
            Console.WriteLine("i: " + i3);

            Console.Read();
        }
    }
}
