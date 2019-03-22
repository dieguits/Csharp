using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];

            array[0] = 10;
            array[1] = 12;
            array[2] = 10;
            array[3] = 7;
            array[4] = 8;
            array[5] = 12;
            array[6] = 7;
            array[7] = 12;

            string contain = "";

            for (int i = 0; i < array.Length; i++)
            {
                int times = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        times++;
                }

                if (!contain.Contains(array[i].ToString()))
                {
                    if (array[i] > 9)
                        Console.WriteLine(array[i] + " - " + times + " times.");
                    else
                        Console.WriteLine(" " + array[i] + " - " + times + " times.");
                    contain = contain + array[i] + " ";
                }
            }

            Console.WriteLine(contain);
            Console.ReadKey();
        }
    }
}
