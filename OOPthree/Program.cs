// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
using OOPthree.Models;

string name;
double price, quantity, count;
Product p = new Product();
Console.WriteLine("enter product name");
name = Console.ReadLine();

Console.WriteLine("enter product price");
price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter quantity");
quantity = Convert.ToDouble(Console.ReadLine());



p.GetInfo(name);
p.GetInfo(name, price);
p.GetInfo(name, price, quantity);

Console.WriteLine("enter number of products");
count = Convert.ToDouble(Console.ReadLine());
for(int i= 1; i<=count; i++)
{

    Console.WriteLine("enter product name");
    name = Console.ReadLine();

    Console.WriteLine("enter product price");
    price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("enter quantity");
    quantity = Convert.ToDouble(Console.ReadLine());

    p.AddProduct(name, price, quantity);
}
p.DisplayProducts();