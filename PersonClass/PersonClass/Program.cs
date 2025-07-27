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
            Employee Employee1 = new Employee(); //initializes the employee class instance

            Employee1.FirstName = "Sample"; //sets the first and last name for the instance
            Employee1.LastName = "Student";

            Employee1.SayName(); //calls sayname method
        }
    }
}
