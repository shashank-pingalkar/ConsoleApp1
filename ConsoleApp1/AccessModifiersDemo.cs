using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccessModifiersDemo
    {
        private class person
        {
            private string FirstName;
            private string LastName;

            public void insertName(String FirstName,string LastName)
            {
               this.FirstName = FirstName;
               this.LastName = LastName;
            }

            public void displayFullName()
            {
                Console.WriteLine("Full Name is :-"+FirstName+" "+LastName);
            }

        }

        static void Main()
        {
            person p= new person();
            p.insertName("Shashank","Pingalkar");
            p.displayFullName();
        }
    }
}
