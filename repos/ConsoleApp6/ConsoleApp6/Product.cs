using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Product : IProduct
    {
        public string GetProductName()
        {
            return "mobile";
        }
        public string GetProductPrice()
        {
            return "50000";
        }

    }
}
