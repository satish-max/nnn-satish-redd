﻿using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
   public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal say hello");
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
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public override void Sing()
        {
            Console.WriteLine("dog song");
        }
    }
}