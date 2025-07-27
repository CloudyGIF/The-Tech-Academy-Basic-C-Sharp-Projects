using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Employee : person //inherited class from person
    {
        private int id {  get; set; } //class specific property

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //abstract method override
        }

    }
}
