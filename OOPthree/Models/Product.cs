using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPthree.Models
{
    public class Product
    {
        public string Name { get; set; } //prop must be capital
        public double Price { get; set; }
        public double Quantity { get; set; }
        
        public  bool Instock { get; set; }

        static List<Product> productlist = new List<Product>();
        public void AddProduct(string name, double price, double quantity)
        {
            bool value = checkStock(quantity);
          
            productlist.Add(new Product { Name = name, Price = price, Quantity = quantity,Instock=value});
        }

        public static  bool checkStock(double quantity)
        {
            if (quantity<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string isInStock()
        {
            if (checkStock(Quantity)) {
               return " the product is in stock";
            }
            else
            {
                return " the product out of stock";
            }
        }

        public void DisplayProducts()
        {
            foreach (Product product in productlist)
            {
                Console.WriteLine("Name : " + product.Name + "   " + "price : " + product.Price + "  " + " Kd  " +
                  "Quantity" + product.Quantity + "   " + " total  " + CalcTotal(product.Price, product.Quantity) + "  "+ product.isInStock());
            }
        }



        public void GetInfo(string name)
        {
            Console.WriteLine($"product name : {name}");

        }
        public void GetInfo(string name, double price)
        {
            Console.WriteLine($"product name : {name}, price: {price}");

        }

        public void GetInfo(string name, double price, double quantity)
        {
            Console.WriteLine($"product name : {name}, price: {price}, Quantity  {quantity} ");
           
        }
         public double CalcTotal( double price, double quantity )
        {
            return price * quantity;
        }



    }
}
