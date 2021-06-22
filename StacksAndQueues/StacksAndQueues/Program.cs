using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Stacks and Queues Program!");

            // Creating object
            LinkedListClass SQ = new LinkedListClass();
            SQ.Push(70);
            SQ.Push(30);
            SQ.Push(56);
            SQ.Display();
            SQ.IsEmpty();
            SQ.Display();
        }
    }
}
