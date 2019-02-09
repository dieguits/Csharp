using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Enter the mark: ");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark <= 50)
            {
                Console.WriteLine("Fail");
            }
            else if (mark >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (mark > 80 && mark < 90)
            {
                Console.WriteLine("Very Good");
            }
            else if (mark > 70 && mark < 80)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Average");
            }

            Console.ReadKey();
        }
    }
}
