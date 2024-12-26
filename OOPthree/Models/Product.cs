using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPthree.Models
{
    public class Product
    {
        public string Name { get; set; } //prop must be capital
        public double Price { get; set; }
        public double Quantity { get; set; }

        List<Product> productlist = new List<Product>();
        public void AddProduct(string name, double Price, double Quantity)
        {
            productlist.Add(new Product { Name = name, Price = Price, Quantity = Quantity });
        }


        public void DisplayProducts()
        {
            foreach (Product product in productlist)
            {
                Console.WriteLine("Name : " + product.Name + "   " + "price : " + product.Price + " Kd  " +
                  "Quantity" + product.Quantity + " total  " + CalcTotal(product.Price,product.Quantity));
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
