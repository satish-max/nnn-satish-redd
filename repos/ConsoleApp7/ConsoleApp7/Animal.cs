using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Animal :IAnimal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
}
