using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class search
    {
        static void Main()
        {
            string[] arr = { "Alic", "Bob", "Charli", "David" , "Emily" };
            string sear = "Emily";
            string found = " ";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sear)
                {
                    found = arr[i];

                }

                if (found == sear)
                {
                    Console.WriteLine("Name was Found :-" + found);
                }
                else
                {

                    Console.WriteLine("Name was not Found");
                }

            }

        }
    }
}
