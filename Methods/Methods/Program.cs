using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer");
            int input = Convert.ToInt32 (Console.ReadLine());

            Number newnumber = new Number();
            newnumber.Value = input;

            Console.WriteLine("This is your number + 10 : " + newnumber.AddNumber10());
            Console.WriteLine("This is your number multiplied by 100 : " + newnumber.MultiplyBy100());
            Console.WriteLine("This is your number - 1 : " + newnumber.Minus1());

        }
    }
}
