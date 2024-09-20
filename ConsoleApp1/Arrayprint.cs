using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrayprint
    {
        static void Main()
        {
            int[] nums = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Print Alternate Number :-");
            for (int i = 0; i < nums.Length; i += 2)
            {
                 Console.WriteLine(nums[i]+ " ");

            }
            Console.WriteLine();
            int count = nums.Length;
            Console.WriteLine("Print elements in the array:- " + count);

            int min = nums[0];
            int max = nums[0];
            for (int j = 0; j < nums.Length; j++)
            {
                count++;

                if (min > nums[j])
                {
                    min = nums[j];
                }
                if(max > nums[j])
                {
                    max = nums[j];
                }
            }

            Console.WriteLine("Print Smallest Number :-"+min);
            Console.WriteLine("Print Largest :-" + max);

        }

    }
}
