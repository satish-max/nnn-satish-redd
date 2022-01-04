using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    abstract class AbsClass
    {
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public abstract int MultiplyTwoNumbers(int num1, int num2);
    }
     class AbsDerived : AbsClass
    {
        static void Main(string[] args)
        {
            AbsDerived a = new AbsDerived();
            int add = a.AddTwoNumbers(2, 3);
            int mul = a.MultiplyTwoNumbers(3, 4);
            Console.WriteLine("add : {0}, mul : {1}", add, mul);
        }
        public override int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
