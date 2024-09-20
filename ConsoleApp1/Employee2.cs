using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class person2
    {
        internal int EmployeeID;
        internal string EmployeeNAME;
        internal string ADDRESS;

        public void set(int employeeid, string employeename, string address)
        {
            this.EmployeeID = employeeid;
            this.EmployeeNAME = employeename;
            this.ADDRESS = address;
        }
    }
     class Employee2 : person2
    {
        public void display()
        {
            Console.WriteLine("EmployeeID :-" + EmployeeID);
            Console.WriteLine("Employee Name :-" +EmployeeNAME);
            Console.WriteLine("Address :-" + ADDRESS);
        }

        static void Main()
        {
           Employee2 employee2 = new Employee2();
            employee2.set(101, "SHASHANK", "pune");
            employee2.display();
        }
    }
}
