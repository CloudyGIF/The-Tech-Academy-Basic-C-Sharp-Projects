using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<string> names = new List<string> { "Anna", "Joe", "Katya", "Bob", "Joe", "Alex", "Marty", "Velma", "Richard", "Stacy" };
            List<string> lastnames = new List<string> { "Brown", "Green", "Blue", "Purple", "Orange", "Pink", "Grey", "Lime", "Darkgrey", "Clear" };

            for (int i = 0; i < names.Count; i++)
            {
                employees.Add(new Employee { FirstName = names[i], LastName = lastnames[i], id = i });
                //honestly I did not save any time writting it out this way
                //essentially adds 10 employees to the list from 2 lists above
            }

            List<Employee> Joes = new List<Employee>(); //initializes the list for employees named Joe

            foreach (Employee employee in employees)
            {
                if(employee.FirstName == "Joe") //if firstname matches Joe the employee is added to the Joes list
                {
                    Joes.Add(employee);
                    
                }
            }

            List<Employee> Joes2 = employees.Where(x => x.FirstName == "Joe").ToList(); //the same a the above, except with a lambda expression

            List<Employee> ids = employees.Where(x => x.id > 5).ToList(); //creates a new list of employyes with ids where all the ids are greates than 5



        }
    }
}
