using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace constructor
{
    public class Animal
    {
        public string Type { get; set; }
        public int Age { get; set; } //class properties
        public string Name { get; set; }


       
        public Animal(string type, int age, string name) //main constructor
        {
            Age = age;
            Type = type;
            Name = name;
        }

        public Animal(string type, int age) : this(type, age, "Unnamed") //chained constructor
        {
            
        }
    }
}
