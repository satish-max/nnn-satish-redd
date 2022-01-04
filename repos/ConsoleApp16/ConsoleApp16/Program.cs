using System;
using System.Collections;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("hello");
            myQueue.Enqueue(null);
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Dequeue();
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
