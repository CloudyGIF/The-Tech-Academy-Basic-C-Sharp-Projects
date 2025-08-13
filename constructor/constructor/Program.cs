using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int num = 10; 

            var animal = "dog";

            Animal animal1 = new Animal(animal, num); //chained constructor initalized 

            Console.WriteLine(animal1.Name + " " +  animal1.Type);
        }


    }
}
