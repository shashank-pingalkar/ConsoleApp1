using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayListExp
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                a.Add(i);
            }

            //Print Element
            Console.WriteLine("\n Print Element:- ");
            foreach (int i in a)
            {
                Console.Write(i + " \n");
            }

            //Remove Element
            Console.WriteLine("\n Remove Element:-");
            a.Remove(3);
            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            //Reverse Element
            Console.WriteLine("\n Reverse Element:-");
            a.Reverse();
            Console.WriteLine();
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }



            Console.Read();
        }
    }
}
