using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPthree.Models
{
    public class Product
    {
       public string name { get; set; }
       public double price { get; set; } 
       public double quantity { get; set; }

        List<Product> product = new List<Product>();
        public void AddProducts( string Name, double Price, double Quantity)
        {
            product.Add(new Product { name = Name, price = Price, quantity = Quantity });
        }

      
        public void SetName(string Name) { name = Name; }


        public string GetName() { return name; }

        public string GetInfo(string name, double price)
        {
            return "Name: " + name + " " + " Price :" + price;
        }

        public static string TotInfo(string name, double price, double quantity)
        {

            double Total = price * quantity;
   
            return $"product  {name } , price { price} , quantity {quantity }, Total { Total } ";
        }

         public void GetProduct()
        {  foreach (var custmer in product) {
                Console.WriteLine("Name "+custmer.name +"price "+ custmer.price+" Qty "+ custmer.quantity+" Total "+(quantity*price));
                    }
        }

    }
}
