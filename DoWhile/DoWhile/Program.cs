using System;


namespace DoWhile
{
    internal class Program
    {
        static void Main()
        {
            bool good_day = false; //variable good day is established
            

            do
            {
                Console.WriteLine("Please enter the day of the week."); //asks the user to input the current day of the week and assigns it to a variable
                string weekday = Console.ReadLine().ToLower();

                switch (weekday)
                {
                    case "monday":
                        Console.WriteLine("\"I hate Mondays\" - Garfield \n Mondays are not a good day!");
                        break;
                    case "tuesday":
                        Console.WriteLine("Tuesday is not a good day");
                        break;
                    case "wednesday":
                        Console.WriteLine("Wednesday is not a good day");
                        break;
                    case "thursday":
                        Console.WriteLine("Thursday is not a good day");
                        break;
                    case "friday":
                        Console.WriteLine("Friday is a good day"); //if the weekday is friday, saturday or sunday, the condition is met and the day is good.
                        good_day = true; //if not the user would restart the loop and try again
                        break;
                    case "saturday":
                        Console.WriteLine("Saturaday is a good day!");
                        good_day = true;
                        break;
                    case "sunday":
                        Console.WriteLine("Sunday is a good day!");
                        good_day = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid day of the week"); //default statement
                        break;

                }
            }
            while (!good_day);

        }
    }
}
