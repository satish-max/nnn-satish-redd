﻿using System;
using System.Collections;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("hello");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
