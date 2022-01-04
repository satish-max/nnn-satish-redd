using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ord = new Order();
            string productName = ord.GetProName();
            string orderName = ord.GetOrdName();
            Console.WriteLine(orderName + " from " + productName);
        }
    }
}
