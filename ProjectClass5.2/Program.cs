using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sarta = "";
            string sol = "";

            for (int i = 1; i < 6; i++)
            {
                sarta += i.ToString();
                Console.WriteLine(sarta);
            }

            //sarta = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    sol += j + "\t";
                }
                Console.Write("\r");
                Console.WriteLine("");
                Console.WriteLine(sol);
            }

            //Console.WriteLine(sarta);
            Console.ReadKey();
        }
    }
}
