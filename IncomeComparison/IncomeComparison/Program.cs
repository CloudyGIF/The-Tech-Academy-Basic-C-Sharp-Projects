using System;


namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Greeting
            Console.WriteLine("Person 1 \n Hourly Rate?"); 
            int p1_rate = Convert.ToInt32(Console.ReadLine()); //gets p1 hourly rate in int
            Console.WriteLine("Hours worked per week?");
            int p1_hours = Convert.ToInt32(Console.ReadLine()); //gets p1 hours worked
            Console.WriteLine("Person 2 \n Hourly Rate?");
            int p2_rate = Convert.ToInt32(Console.ReadLine()); //gets p2 hourly rate in int
            Console.WriteLine("Hours worked per week?");
            int p2_hours = Convert.ToInt32(Console.ReadLine()); //gets p2 hours worked

            int p1_salary = p1_rate * p1_hours * 4 * 12;
            int p2_salary = p2_rate * p2_hours * 4 * 12; //calculates the salary by multiplying the hourly rate by number of hours per week * 4 weeks * 12 months

            bool statement = p1_salary > p2_salary; //compares the salaries

            Console.WriteLine("Annual salary of Person 1:\n " + p1_salary);
            Console.WriteLine("Annual salary of Person 2:\n " + p2_salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n " + statement); //prints results
        }
    }
}
