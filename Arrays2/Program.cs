﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            int cont = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = cont;
                    cont++;
                }
            }

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //if (i == (array.GetLength(0) - array.GetLength(1)) && j == (array.GetLength(0) - array.GetLength(1)))
                    //    sum += array[i, j];
                    //else if(i == (array.GetLength(0) - array.GetLength(1)) && j == array.GetLength(0)-1)
                    //    sum += array[i, j];
                    //else if(i == array.GetLength(1)-1 && j == (array.GetLength(0) - array.GetLength(1)))
                    //    sum += array[i, j];
                    //else if(i == array.GetLength(1)-1 && j == array.GetLength(0)-1)
                    //    sum += array[i, j];

                    if ((i == 0 || i == array.GetLength(0) - 1) && (j == 0 || j == array.GetLength(1) - 1))
                        sum += array[i, j];
                }
            }

            Console.WriteLine("The sumation is: " + sum);
            Console.WriteLine();


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (array[i, j] < 10)
                        Console.Write(" " + array[i, j] + " ");
                    else
                        Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
