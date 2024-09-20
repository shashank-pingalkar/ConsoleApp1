using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class reverse_String
    {
        static void Main()
        {


            string s = "CODEMIND TECHNOLOGY";
            int i = s.Length - 1;
            String reverse = "";
            while (i >= 0)
            {
                reverse += s[i];
                i -= 1;

            }
            Console.WriteLine("the reverse string is : " + reverse);
        }
        
    }
}
