using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT CONVERTION
            int letter = 'A';

            Console.WriteLine("La letra " + letter);

            Double x = 3;
            double b = 3;
            double c = 4;

            double sum = (x + b + c) / 3;

            Console.WriteLine(sum);

            //EXPLICIT CONVERTION
            Char l = (Char)68;

            Console.WriteLine(l);

            String s = null;
            String s2 = "abc";
            String s3 = "xcv";

            Console.WriteLine("This is the string: " + s + s2 + s3);

            double e = 14.5;
            double r = 30.5;

            //CONCATENATION
            String conca = "Concat " + e + r;
            Console.WriteLine(conca);

            //SUM
            conca = "Concat " + (e + r);

            Console.WriteLine(conca);


            String sarta = "Sir \\ said \"don't be late\" in the class";

            Console.WriteLine(sarta);

            String x1 = "20.5";
            String x2 = "20999999999999999999999999999999999999999999999999766787878787.9888888888888888888888888888888888888888888888888";
            double d1 = Convert.ToDouble(x1);
            double d2 = Convert.ToDouble(x2);
            double result = d1 + d2;

            Console.WriteLine("Este: " + result.ToString());
            Console.WriteLine("---------------------------------------------------------------------");



            Console.ReadKey();
        }
    }
}
