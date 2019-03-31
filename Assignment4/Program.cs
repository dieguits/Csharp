using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] { { 5, 10, 15, 20 }, { 2, 4, 6, 8 }, { 1, 3, 5, 7 }, { 20, 200, 10, 6 } };

            sumLeftDiagonal(array);
            sumRightDiagonal(array);

            Console.ReadKey();
        }

        private static void sumRightDiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || j == 0) && (i == array.GetLength(0)-1 || j == array.GetLength(0)-1))
                    {
                        sum += array[i, j];
                    }

                    if((i== array.GetLength(0)-2 || j == array.GetLength(0)-2) && (i == 1 || j == 1))
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("Sum of right diagonal: " + sum);
        }

        private static void sumLeftDiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("Sum of left diagonal: " + sum);
        }
    }
}
