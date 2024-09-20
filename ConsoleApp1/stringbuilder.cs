using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class stringbuilder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Believe in yourself");
            sb.AppendLine(" too ");


            Console.WriteLine(sb.ToString());

            sb.Replace("too", "Have faith in your abilities!");
            Console.WriteLine(sb.ToString());

            sb.Remove(19, 31);
            Console.WriteLine(sb.ToString());
        }
    }
}
