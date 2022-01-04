using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            string name = prod.GetProductName();
            string price = prod.GetProductPrice();
            Console.WriteLine(name + " cost is " +price);
        }
    }
}
