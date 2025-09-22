using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.Marshalling;
using StudentProject;



namespace StudentProject
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new StudentContext())

            {
                var name = "";
                var lname = "";
                Console.WriteLine("Welcome to the Student Database! \n Let's add a student to the Db. Please enter the student's First Name");
                name = Console.ReadLine();
                if (name == "")
                {
                    do
                    {
                        Console.WriteLine("The student's name cannot be null, please try again");
                        name = Console.ReadLine();
                    }
                    while (name == "");
                }

                Console.WriteLine("Please enter the student's Last Name");
                lname = Console.ReadLine();
                if (lname == "")
                {
                    do
                    {
                        Console.WriteLine("The student's last name cannot be null, please try again");
                        lname = Console.ReadLine();
                    }
                    while (lname == "");
                }

                Console.WriteLine("Please enter the student's grade");

                int grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the student's age");

                int age = Convert.ToInt32(Console.ReadLine());

                var newstudent = new Student { FirstName = name!, LastName = lname!, age = age, grade = grade };

                db.Students!.Add(newstudent);

                db.SaveChanges();

                Console.WriteLine("Thank you for submitting the student information!");
            }



        }
    }
}