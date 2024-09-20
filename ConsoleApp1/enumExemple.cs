using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class enumExemple
    {
        public enum Year
        {
          January,
          February,
          March,
          April,
          May,
          June,
          July,
          August,
          September,
          October,
          November,
          December,
        }
        public static void Main()
        {

            Year month = Year.September;

            switch (month)
            {
                case Year.January:
                    Console.WriteLine("January");
                    break;
                case Year.February:
                    Console.WriteLine("February");
                    break;
                case Year.March:
                    Console.WriteLine("March");
                    break;
                case Year.April:
                    Console.WriteLine("April");
                    break;
                case Year.May:
                    Console.WriteLine("May");
                    break;
                case Year.June:
                    Console.WriteLine("June");
                    break;
                case Year.July:
                    Console.WriteLine("July");
                    break;
                case Year.August:
                    Console.WriteLine("August");
                    break;
                case Year.September:
                    Console.WriteLine("September");
                    break;
                case Year.October:
                    Console.WriteLine("October");
                    break;
                case Year.November:
                    Console.WriteLine("November");
                    break;
                case Year.December:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Input Please enter a valid month name");
                    break;
            }

            if (month == Year.January)
            {
                Console.WriteLine("January is the starting month of the year");

            }
            else if(month == Year.December)
            {
                Console.WriteLine("December is the ending month of the year");
            }
            else
            {
                Console.WriteLine($"{month} is a regular month of the year");
            }

        }

    }
}
