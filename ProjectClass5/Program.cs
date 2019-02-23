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
            int j = 1;
            int suma2 = 0;

            for (; ; )
            {
                if (j < 4)
                {
                    suma2++;
                    j++;
                    Console.WriteLine(j + "-" + suma2);
                }
                if (j == 4)
                {
                    break;
                }
                Console.WriteLine("-");
            }
        }
    }
}
