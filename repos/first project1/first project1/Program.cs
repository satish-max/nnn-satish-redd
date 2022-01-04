using System;

namespace first_project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("given num is even");
            }
            else
            {
                Console.WriteLine("given num is odd");
            }
                   }
    }
}
