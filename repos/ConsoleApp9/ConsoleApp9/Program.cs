using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            double CurrentBalance = obj.GetBalance();
            obj.balance = 2000000;
        }
    }
}
