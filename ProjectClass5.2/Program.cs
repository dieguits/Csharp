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
            sarta = sarta + 1;
            for (int i = 5; i > 0; i--)
            {
                sol = "";
                for (int j = 1; j < i; j++)
                {
                    if (i == 5)
                    sol += j + "\t";
                    else
                        sol += "\t" + j + "\t";
                }
                sol = "\r\n\t" + sol;
                //Console.WriteLine("");
                Console.WriteLine(sol);
                if (i == 6)
                    break;
            }

            //Console.WriteLine(sarta);
            Console.ReadKey();
        }
    }
}
