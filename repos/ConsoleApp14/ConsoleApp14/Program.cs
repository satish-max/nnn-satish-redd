using System;
using System.Collections;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("two");
            arryList1.Add(3);
            arryList1.Add(4.5);
            int FirstElement = (int)arryList1[0];
            string SecondElement = (string)arryList1[1];
            int ThirdElement = (int)arryList1[2];
            double FourthElement = (double)arryList1[3];
            Console.WriteLine(FirstElement);
            Console.WriteLine(SecondElement);
            Console.WriteLine(ThirdElement);
            Console.WriteLine(FourthElement);
        }
    }
}
