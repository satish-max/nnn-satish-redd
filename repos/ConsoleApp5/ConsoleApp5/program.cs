using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class program
    {
        static void Main()
        {
            Student stud = new Student();
            string name = stud.GetName();
            string location = stud.GetLocation();
            Console.WriteLine(name + " is located at " + location);
        }
     }
}
