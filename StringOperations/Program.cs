using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a test string, please check carefully";

            //Start with
            Console.WriteLine(str.StartsWith("This") == true ? "YES" : "NO");

            //endWith
            Console.WriteLine(str.EndsWith("lly") == true ? "YES" : "NO");
            
            //IndexOf
            Console.WriteLine(str.IndexOf("test"));

            //LastIndexOf
            Console.WriteLine(str.LastIndexOf("check"));

            //Insert
            Console.WriteLine(str.Insert(5, "ZYX"));

            //Remove
            Console.WriteLine(str.Remove(4));

            //Replace
            Console.WriteLine(str.Replace("This", "Those"));

            //substring
            string nombre = "Perez, Diego";
            //Console.WriteLine(nombre.IndexOf(','));
            Console.WriteLine(nombre.Substring(nombre.IndexOf(',') + 1).Replace(" ", ""));

            Console.WriteLine(nombre.Substring(0, nombre.IndexOf(',') ));
            
            Console.ReadKey();
        }
    }
}
