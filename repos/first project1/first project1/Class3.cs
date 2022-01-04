using System;
using System.Collections.Generic;
using System.Text;

namespace first_project1
{
    class Class3
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            if (!(a == 1 && b == 2))
            {
                Console.WriteLine(true);
            }
            if (a != 1 || b != 2)
            {
                Console.WriteLine(true);
            }
        }
    }
}

