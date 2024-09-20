using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        protected int EmployeeID;
        protected String EmployeeName;
        protected String Address;

        public void set(int EmployeeID, String EmployeeName, String Address)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.Address = Address;
        }

        public void display() 
        {
            Console.WriteLine("Employee ID :-" + EmployeeID);
            Console.WriteLine("Employee Name :-" + EmployeeName);
            Console.WriteLine("Employee Address :-" + Address);
        }
    }
}
