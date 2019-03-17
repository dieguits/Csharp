using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 5;
            int n = Calculate(x, y:y, name:"Diego");

            Console.WriteLine("The result: " + n);
            

            Double.Parse("12.6");
            float.Parse("12.7");
            decimal.Parse("12.7");

            Convert.ToDecimal(x);
            float.TryParse("12.7", out float n1);
            n1 = 12.7f;
            Console.WriteLine(n1);
            Console.ReadKey();
        }

        private static int Calculate(int x = 0, int y= 0, string name= "NoName")
        {
            int n = 0;
            n = x + y;
            Console.WriteLine("Hello " + name);

            return n;
        }
    }
}
