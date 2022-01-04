using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData td = new TestData();
            int add = td.Add(2 ,3 ,4);
            Console.WriteLine(add);
            int add2 = td.Add(4, 4);
            Console.WriteLine(add2);

        }
    }
}
