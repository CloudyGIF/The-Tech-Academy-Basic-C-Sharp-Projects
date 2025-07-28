using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");

                string input = Console.ReadLine().ToLower();  //converts the input string to lower case in order to avoid capitalisation throwing an error


                Weekdays CurrentDay = (Weekdays)Enum.Parse(typeof(Weekdays), input); //parses the input as part of the Weekdays enum and assigns it to the CurrentDay


                Console.WriteLine("Thank you for the input, the current day is: " + CurrentDay
                    .ToString());
            }
            catch (ArgumentException ex) //catch block with the relevant exception type
            {

                Console.WriteLine("Please enter an actual day of the week.");
            }

        }




    }
    
}

