using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade;

            Console.WriteLine("Enter the grade: ");
            grade = Console.ReadLine().ToUpper();

            

            switch (grade)
            {
                case "E":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                    Console.WriteLine("Very Good");
                    break;
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "A":
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

            Console.ReadKey();
        }
    }
}
