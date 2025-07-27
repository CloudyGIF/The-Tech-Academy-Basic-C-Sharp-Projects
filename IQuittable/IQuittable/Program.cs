using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQuittable;

namespace IQuittable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee { FirstName = "Sample", LastName = "Student" }; //initializes the employee class instance

            IQuittable Employee2 = new Employee { FirstName = "Sample", LastName = "Student 2" }; //Employee2 is of IQuittable type though polymorphism to Employee

            Employee2.Quit(); //intreface method

            Employee1.SayName(); //calls sayname method
        }
    }
}
