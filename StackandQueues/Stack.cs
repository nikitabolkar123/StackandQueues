using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StackandQueues
{
    internal class Stack
    {
        public Node top;

        public Stack()
        {
            this.top = null;
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(" Pushed to Stack is :" + data);
        }

        public void display()
        {
            int i = 1;
            int size = 0;
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine(" Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($" Element {i} in the Stack is : " + temp.data);
                temp = temp.next;
                size = i;
                i++;
            }
            Console.WriteLine(" Total Element of Size is :" + size);
        }
    }
}

