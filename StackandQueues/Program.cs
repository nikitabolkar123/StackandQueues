using System;

namespace StackandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(56);
            stack.push(30);
            stack.push(70);
            stack.display();
            stack.peak();
            stack.pop();
            stack.peak();
            stack.pop();
            stack.peak();
            stack.pop();
            stack.display();
        }
    }
}