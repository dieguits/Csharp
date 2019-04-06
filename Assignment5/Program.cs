using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the access modifiers properly so that the class is accessed by everybody; 
            //fields are not accessed by anybody except the class itself. 

            //Create 3 objects of the class with different value.
            Product salt = new Product();
            salt.Id = 321;
            salt.Name = "Pink Salt";
            salt.Description = "Pink Himalayan Sea Salt 16oz";
            salt.Price = 5.99;
            salt.CreateDate = new DateTime(2019, 04, 06);
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Price: " + salt.GetProductPrice());
            Console.WriteLine("Display: " + salt.GetDisplayText());
            
            //Print out the value of all three object by reading GetProductPrice() and GetDisplayText()

            Product coke = new Product();
            coke.Id = 987;
            coke.Name = "Regular Coke";
            coke.Description = "Six Pack Coke 225 ml.";
            coke.Price = 3.99;
            coke.CreateDate = new DateTime(2019, 04, 06);

            Console.WriteLine("===========================================================================");
            Console.WriteLine("Price: " + coke.GetProductPrice());
            Console.WriteLine("Display: " + coke.GetDisplayText());

            Product milk = new Product();
            milk.Id = 852;
            milk.Name = "Beatrice Milk Pack";
            milk.Description = "Three Pack Milk * 980 ml.";
            milk.Price = 4.89;
            milk.CreateDate = new DateTime(2019, 04, 06);

            Console.WriteLine("===========================================================================");
            Console.WriteLine("Price: " + milk.GetProductPrice());
            Console.WriteLine("Display: " + milk.GetDisplayText());

            Console.WriteLine("===========================================================================");

            Console.ReadKey();
        }
    }
}
