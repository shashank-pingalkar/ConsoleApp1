using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operators
    {
        public static void Main()
        {
            //Arithmetic Operators
            int a = 10;
            int b = 3;

            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine($"Addition of two number is :- {a + b}"); //addition
            Console.WriteLine($"Substraction :- {a - b}");
            Console.WriteLine($"Multiplication:- {a * b}");
            Console.WriteLine($"Divistion :- {a / b}");
            Console.WriteLine($"Mod :- {a % b}");


            Console.WriteLine();
            //Relational Operators
            Console.WriteLine($" a == b :- {a == b}");
            Console.WriteLine($" a != b :- {a != b}");
            Console.WriteLine($" a > b :- {a > b}");
            Console.WriteLine($" a < b :- {a < b}");
            Console.WriteLine($" a >= b :- {a >= b}");
            Console.WriteLine($" a <= b :- {a <= b}");


        }


    }
}
