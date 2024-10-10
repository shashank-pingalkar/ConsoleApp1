using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class NegativeNumber : Exception
    {
        public NegativeNumber(string? message) : base(message)
        {
        }
    }

    internal class NevException
    {


        static void Main()
        {
            try
            {
                Console.WriteLine("Enter possitive number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    throw new NegativeNumber("Negative number are not allowed");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            catch (NegativeNumber ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
