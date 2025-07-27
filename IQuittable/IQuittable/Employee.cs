using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    public class Employee : person, IQuittable //inherited class from person
    {
        private int id { get; set; } //class specific property

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //abstract method override
        }

        public void Quit() //defines the quit method
        {
            Console.WriteLine("The employee " + FirstName + " " + LastName + " has quit");
        }

    }
}
