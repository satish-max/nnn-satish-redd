using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal anm1 = new Dog();
             anm1.Greet();
             anm1.Talk();
            anm1.Sing();           
        }
    }
}
