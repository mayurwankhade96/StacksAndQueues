using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class LinkedListClass
    {
        public Node top;
        public LinkedListClass()
        {
            this.top = null;
        }

        /// <summary>
        /// Method to push element in the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " pushed to stack");
        }

        /// <summary>
        /// Method to display stack
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
