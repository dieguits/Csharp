using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaddedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[3];
            array[1] = new int[4];
            array[2] = new int[2];

            populateArray(array);

            printArray(array);

            sumAllArray(array);

            Console.WriteLine("Listo");
            Console.ReadKey();
        }

        private static void sumAllArray(int[][] array)
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }

            Console.WriteLine("The total sumation is: " + sum);
        }

        private static void printArray(int[][] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void populateArray(int[][] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = j + 1;
                }
            }
        }
    }
}
