using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class stackExp
    {
        static void Main()
        {
           
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine("Stack after adding 5 elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            int removedElement = stack.Pop();
            Console.WriteLine($"\nRemoved element: {removedElement}");

            Console.WriteLine("\nStack after removing top element:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
