using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Number
    {
        public int Value { get; set; }
        public int AddNumber10()
        {
            return Value + 10;
        }

        public int MultiplyBy100()
        {
            return Value * 100;
        }

        public int Minus1()
        {
            return Value - 1;
        }
    }
}
