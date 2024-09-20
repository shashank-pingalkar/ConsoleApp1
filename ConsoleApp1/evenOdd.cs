using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class evenOdd
    {
        public static void Main()
        {

            int[] arr = { 50,30,80,10,40};
            int max= arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum Number is:- " + min);
            Console.WriteLine("Maximum Number is :-" + max);
        }
    }
}
