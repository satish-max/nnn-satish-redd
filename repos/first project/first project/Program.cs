using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("how much sleep did you have last night");
            int hoursOfSleep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello, " + name);
            if (hoursOfSleep < 8)
            {
                Console.WriteLine("you must be feeling tired!");
            }
            else
            {
                Console.WriteLine("you seen well rested");
            }
        }
    }
}
