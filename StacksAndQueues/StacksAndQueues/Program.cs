using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Stacks and Queues Program!");

            // Creating object
            //LinkedListClass stack = new LinkedListClass();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //stack.Display();
            //stack.IsEmpty();
            //stack.Display();

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
