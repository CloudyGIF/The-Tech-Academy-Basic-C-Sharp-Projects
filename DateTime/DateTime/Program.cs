using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime currenttime = DateTime.Now; //gets current time

            Console.WriteLine("It is currently : " + currenttime + "\n Please choose a number"); //print to console

            int input = Convert.ToInt32(Console.ReadLine()); //gets input int

            DateTime newtime = currenttime.AddHours(input); //add hours

            Console.WriteLine("in {0} hours, it will be {1}", input, newtime); //prints result
        }

    }
}
