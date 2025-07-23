using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Math
    {
        
           

       

            public int MathOperation(int num)
            {
                return num + 10; //int method
            }

            public decimal MathOperation(decimal num, decimal num2)
        {
            return  num + num2 + 10.1234m; //decimal parameters method overload
        }

        public int MathOperation(string text)
        {
            int text_num = Convert.ToInt32(text); //string parameter method overload

            return 11 + text_num;
        }


    }
}
