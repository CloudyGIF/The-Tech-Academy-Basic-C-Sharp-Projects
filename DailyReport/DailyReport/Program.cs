using System;
using System.Runtime.Remoting.Lifetime;


namespace DailyReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \n Studen Daily Report"); //Greeting
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //gets the user name from input
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine(); //gets the user course name from input
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine()); //gets the page num and casts to int
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool help_needed = Convert.ToBoolean(Console.ReadLine()); //gets the true or false value and casts to bool
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine(); //gets user experience
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine(); //gets user feedback
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine()); //gets hours studied in int
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day"); 
        }
    }
}
