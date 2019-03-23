using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            int sum = 0;
            array[0] = new int[3];
            array[1] = new int[2];
            array[2] = new int[4];

            fillArray(array);
            printArray(array);

            //Console.WriteLine(array[1].GetLength(0));

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    sum += array[i][j];
                }
            }
            Console.WriteLine("Total sum: " + sum);
            Console.ReadKey();
        }

        private static void printArray(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void fillArray(int[][] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    count++;
                    array[i][j] = count;
                }
            }
        }
    }
}
