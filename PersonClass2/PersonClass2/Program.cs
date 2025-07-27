using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee { FirstName = "Sample", LastName = "Student"}; //initializes the employee class instance

 
            Employee1.SayName(); //calls sayname method
        }
    }
}
