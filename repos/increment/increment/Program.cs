using System;

namespace increment
{
    class Program
    { 
            static void Increment(ref int i)
            {
                i = i + 1;
            }
            static void Main()
            {
                int x = 1;
            Increment(ref x);
                Console.WriteLine("the value of x is: " + x);
                Console.Read();
            }
        }
    }

