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

            Math2 class_instance2 = new Math2();

            Console.WriteLine("Please choose your first number");

            int param1 = Convert.ToInt32(Console.ReadLine()); //gets the first input number

            Console.WriteLine("Please choose your second number, however it is optional");

            string param2 = Console.ReadLine();

            int result4;

            if (param2 == "") //turns out enter is not null but "", so param2 is a string format to accomadate that and not result in Format error.
            {
                result4 = class_instance2.MathOperation(param1); //if the second input is "" then only 1 parameter is passed
            } else
            {
                result4 = class_instance2.MathOperation(param1, Convert.ToInt32(param2)); //if the second input is not blank then 2 parameters are parsed
            }

            Console.WriteLine(result4);

            Math3 class_instance3 = new Math3(); //initialized class Math3

            class_instance3.Operation(10, 20); //calls the void method

            class_instance3.Operation(num: 20, num2: 30); //REVISION: calls the method in the class specifying parameters by name

            Console.ReadLine();

            
            

            



        }
    }
}
