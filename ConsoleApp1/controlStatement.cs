using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class controlStatement
    {
        public static void Main()
        { 
            //Sum of Array
            int[] numbers = { 75,85,95,30,13,45,90 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the array elements is:- " + sum);

            //Calculating the Average value of Array
            int avg = sum / numbers.Length;
            Console.WriteLine("The Average value of Given Array is :-" + avg );

           

        }
    }
}
