using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class person
    {
        public string FirstName { get; set; } //first name and last name properties
        public string LastName { get; set; }

        public void SayName() //void method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        

        
    }
}
