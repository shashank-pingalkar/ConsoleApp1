using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class publicExp
    {
        public int publicproperty {  get; set; }

        public void show()
        {
            Console.WriteLine("public property value :-" +publicproperty);
        }

    }
    public class publicAccessM
    {
        public static void Main()
        {
            publicExp obj = new publicExp();
            obj.publicproperty = 1;
            obj.show();
        }
    }
}
