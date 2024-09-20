using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrimeNumArray
    {
       
        
            static void Main()
            {
                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

                Console.WriteLine("Prime numbers in the array:");
                int index = 0;
                while (index < nums.Length)
                {
                    if (IsPrime(nums[index]))
                    {
                        Console.Write(nums[index] + " ");
                    }
                    index++;
                }
            }

            static bool IsPrime(int number)
            {
                // Numbers less than 2 are not prime
                if (number < 2) return false;

                // Check for factors from 2 up to the square root of the number
                int i = 2;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                    i++;
                }

                return true;
            }

        
    }
}
