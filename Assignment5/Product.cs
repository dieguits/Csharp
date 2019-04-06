using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Product
    {
        /** Create a class named 'Product'. Ok
         *  Declare following fields(
         *  int id, string name, string description, 
         *  double price, and Datetime createDate) in the class. 
         **/

        #region FIELDS

        private int id;
        private string name;
        private string description;
        private double price;
        private DateTime createDate;

        #endregion

        //Declare properties for each field in the class. 

        #region PROPERTIES

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        //Create default constructor and constructor with all the fields; assign values to the fields.
        public Product()
        {

        }

        public Product(int id, string name, string description, double price, DateTime createDate)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.createDate = createDate;
        }

        //Create a method named GetProductPrice() which will return Name and Price of the product.

        public string GetProductPrice()
        {
            return this.name + " - " + this.Price;
        }

        //Create a method called GetDisplayText() which will return all the information of the product except ID.

        public string GetDisplayText()
        {
            return this.name + " - " + this.description + "\n" + this.price + " - " + this.createDate.ToString("MM/dd/yyyy");
        }
    }
}
