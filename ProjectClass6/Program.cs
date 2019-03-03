using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
            float f = 2.4f;

            float result = calculate(2, k);

            result = result * 23;

            Console.WriteLine(result);

            calculate(k);
            
           
            Console.ReadKey();
        }

        #region FUNCTIONS

        static void calculate(int k)
        {
            Console.WriteLine(k);
        }

        public static float calculate(int x, float j)
        {
            float sum = 0;

            sum = x + j;
            Console.WriteLine(sum);

            return sum;
        }

        #endregion

    }
}
