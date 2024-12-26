// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
using OOPthree.Models;

Product p = new Product();
Console.WriteLine("enter name");
p.SetName(Console.ReadLine());

Console.WriteLine("Product name:  " + p.GetName());

Console.WriteLine("enter price");
double price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Product name:  " + p.GetName() +" Product Price: " + price);
double Total=0;

Console.WriteLine("enter quantity");
double quantity = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Product name:  " + p.GetName() + "Product Price: " + price +"quantity is: " + quantity + " total " + Total);

Console.WriteLine(Product.TotInfo(p.GetName(),price, quantity));