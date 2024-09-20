using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class person1
    {
        internal int Employeeid;
        internal string EmployeeName;
        internal string Address;

        public void set(int Empid,string Empname,string address)
        {
            this.Employeeid = Empid;
            this.EmployeeName = Empname;
            this.Address = address;
        }
        
    }
    class Employee1 : person1
    {
        public void display()
        {
            Console.WriteLine("EmployeeID :" + Employeeid);
            Console.WriteLine("EmployeeName :" + EmployeeName);
            Console.WriteLine("Employee Address :" + Address);
        }

        static void Main()
        {
            Employee1 emp1 = new Employee1();
            emp1.set(01, "", "");
            emp1.display();
            
        }
    }
}
