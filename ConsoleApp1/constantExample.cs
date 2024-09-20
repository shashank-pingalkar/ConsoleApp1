using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class constantex
    {
        public int a = 10;
        public const double pi = 3.4554;
        public const String AppName = "Shashank";
        public string name = "Test";


        public void printconstnt()
        {
            Console.WriteLine(name);
            Console.WriteLine($"The value of pi is :- {pi}");
            Console.WriteLine($"The Application Name :- {AppName}");

            name = "Test1";
            Console.WriteLine(name);

        }
    }

    internal class constantExample
    {
        static void Main()
        {
            constantex c = new constantex();
            c.printconstnt();

        }
    }
}
