using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
           int result = calc.Add(3, 5);
            Console.WriteLine(result);

            calc.Multiply(3, 5);
            Console.WriteLine(result);

            calc.Substract(3, 5);
            Console.WriteLine(result);

            calc.Divide(3, 5);
           Console.WriteLine(result);
        }
    }
}
