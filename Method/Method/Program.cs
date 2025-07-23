using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main()
        {
            Math class_instance = new Math(); //Math class is initialized 

            int result = class_instance.MathOperation(19); //returns integer operation

            Console.WriteLine(result);

            decimal result2 = class_instance.MathOperation(19.123m, 123.213m); //returns decimal operation

            Console.WriteLine(result2);

            int result3 = class_instance.MathOperation("20"); //returns string operation

            Console.WriteLine(result3);

        }
    }
}
