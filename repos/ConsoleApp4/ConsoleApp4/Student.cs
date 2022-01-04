using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
   public class Student : IStudent
    {
        public string GetLocation()
        {
            return "india";
        }
        public string GetName()
        {
            return "satish reddy";
        }
    
    }
}
