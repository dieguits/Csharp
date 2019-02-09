using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = ';';
            Console.WriteLine(letter);

            //Casting convertion
            int i = (int)95.5;
            Console.WriteLine(i);

            //Implicit convertion
            double val = 56.0;
            Console.WriteLine(val);

            string firstName = "Diego";
            string lastName = "Perez";
            string fullName = lastName + ",\r" + firstName;
            Console.WriteLine(fullName);

            //Concatenation
            int i1 = 5, i2 = 8;
            string s = "Total: " + i1 + i2;
            Console.WriteLine(s);

            //Operation + Concatenation
            s = i1 + i2 + " Total:";
            Console.WriteLine(s);

            //Escape caracters
            string s2 = "Hello we are trying \"scape\" character";
            Console.WriteLine(s2);

            string s3 = "Hello \\ world";
            Console.WriteLine(s3);

            //FORMAT
            int n1 = 10, n2 = 45;
            int suma = n1 + n2;
            string sum = suma.ToString("f3");
            Console.WriteLine(sum);

            string s5 = "2045,67";
            double d5 = Convert.ToDouble(s5);
            Console.WriteLine(d5);

            string s6 = "d2045.67";
            double sd6;
            bool flag = Double.TryParse(s6, out sd6);
            //double d6 = Double.Parse(s6);
            Console.WriteLine(flag);
            Console.WriteLine(sd6);

            Console.WriteLine("------------------------------------------------");
            //THE NUMBER 0 REPRESENT THE NUMBER OF parameter RECEIVE THE FUNCTION
            string example = string.Format("{0:c}", 1547,2);
            Console.WriteLine(example);

            string ex2 = string.Format("{0:p1}", .023m);
            Console.WriteLine(ex2);

            string ex3 = string.Format("{0:n0}", 15000);
            Console.WriteLine(ex3);

            string ex4 = string.Format("{0:f3}", 432.8175);
            Console.WriteLine(ex4);

            Console.ReadKey();
        }
    }
}
