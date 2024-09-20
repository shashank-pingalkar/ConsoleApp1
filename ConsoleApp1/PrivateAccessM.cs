using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class PrivateAM
    {
        private int privateField;

        public void setfield(int value)
        {
            privateField = value;
        }

        public void show()
        {
            Console.WriteLine("Private field value :-" + privateField);
        }

    }


    internal class PrivateAccessM
    {
        public static void Main()
        {
               // PrivateAM obj = new PrivateAM();
               // obj.setfield(10);
               // obj.show();

            publicExp obj = new publicExp();
            obj.publicproperty = 1;
            obj.show();

        }
    }
}
