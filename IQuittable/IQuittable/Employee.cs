using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    public class Employee : person, IQuittable //inherited class from person
    {
        public int id { get; set; } //class specific property

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //abstract method override
        }

        public void Quit() //defines the quit method
        {
            Console.WriteLine("The employee " + FirstName + " " + LastName + " has quit");
        }

        public static bool operator==(Employee a, Employee b) //overaloads the == operator by returning true or false on id match
        {
            if (a.id == b.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee a, Employee b) //overaloads the != operator by returning false on id match
        {
            if (a.id == b.id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
