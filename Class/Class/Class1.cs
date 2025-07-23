using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public  class Class1
    {
        public void VoidMethod(int num1) //void class with an argument
        {
            Console.WriteLine(num1 / 2); //prints the parameter divided by 2
        }

        public int MathMethod(int num1)
        {
            return num1 + 10; 
        }

        public float MathMethod(float num1) //overloads MathMethod with float data type
        {
            return num1 + 12.21f;
        }


    }
}
