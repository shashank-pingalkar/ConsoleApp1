using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person2(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public void displayPerson()
        {
            Console.WriteLine($"Name :-{Name},Age:-{Age}");

        }

        
    }


    public class Student1 : Person2
    {
        public string ClassName { get; set; }

        public Student1(string name, int age, string className) : base(name, age)
        {
            ClassName = className;
        }

        public void StudentDetails()
        {
            Console.WriteLine($"Student Class: {ClassName}");
        }

    }

    public class singelInheritanceMain
    {
        static void Main()
        {
            Student1 s1 = new Student1("Shashank",26,"MCA");
            s1.displayPerson();
            s1.StudentDetails();


        }
    }

   
}
