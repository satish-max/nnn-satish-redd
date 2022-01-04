using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class2
    {
        static void Increment(int i)
        {
            i = i + 1;
        }
        static void Main()
        {
            int x = 1;
            Increment(x);
            Console.WriteLine("the value of x is: " + x);
            Console.Read();
        }
    }
}
