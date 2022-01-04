using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
   public class Account
    {
        public Account()
        {
            Console.WriteLine("Account created");
        }
        public virtual void AccountName()
        {
            Console.WriteLine("bank account");
        }
    }
    class Customer : Account
    {
        public Customer()
        {
            Console.WriteLine("customer details");
        }
        public override void AccountName()
        {
            Console.WriteLine("satish reddy");
        }
    }
}
