using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            int temp = 0;
            int largest = 0;
            int smallest = 0;
            int temp2 = 0;

            fillArray(array);
            printArray(array);

            smallest = array[array.Length-1];
            temp2 = smallest;

            for (int i = 0; i < array.Length; i++)
            {
                if(largest < array[i])
                {
                    largest = temp;
                    temp = array[i];
                }

                if(smallest > array[i])
                {
                    smallest = temp2;
                    temp2 = array[i];
                }
            }

            Console.WriteLine("Second largest one: " + largest);
            Console.WriteLine("Second smallest one: " + temp2);

            Console.ReadKey();
        }

        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void fillArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                        array[i] = i;
                    else
                        array[i] = i + 1;
                }else
                {
                    array[i] = 1;
                }
            }
        }
    }
}
