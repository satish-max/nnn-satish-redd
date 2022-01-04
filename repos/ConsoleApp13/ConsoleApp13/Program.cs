using System;
using System.Collections;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           SortedList SortedList1 = new SortedList();
            SortedList1.Add(3, "three");
            SortedList1.Add(4, "four");
            SortedList1.Add(1, "one");
            SortedList1.Add(5, "five");
            SortedList1.Add(2, "two");
            Console.WriteLine(SortedList1);
        }
    }
}
