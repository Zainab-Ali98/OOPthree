using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPthree.Models
{
    public class Product
    {
        string name;
        double price, quantity;
        
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

    }
}
