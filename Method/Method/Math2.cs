using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Math2
    {
        public int MathOperation(int num, int num2 = 0) //makes num2 by default 0 , if nothing is input
        {
            if(num2 == 0)
            {
                return (num * 200)/2;
            }else
            {
                return (num * num2 * 200) / 2;
            }
        }
    }
}
