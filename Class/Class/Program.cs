using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your number to be divded by 2 ");

            int param = Convert.ToInt32(Console.ReadLine());  

           Class1 class_instance = new Class1(); //class is initialized 

            class_instance.VoidMethod(param);

            Console.WriteLine(class_instance.MathMethod(10));

            Console.WriteLine(class_instance.MathMethod(10.123f));
        }
    }
}
