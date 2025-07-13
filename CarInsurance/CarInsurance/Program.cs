using System;


namespace CarInsurance
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //gets the age num and casts to int
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine()); //gets the true or false value and casts to bool
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); //gets the tickets num and casts to int

            bool qualified = (age > 15) && (DUI == false) && (tickets <= 3);
            Console.WriteLine("Qualified? \n" + qualified);
        }
    }
}
