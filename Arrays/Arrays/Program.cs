using System;
using System.Collections.Generic;


namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            string[] stringArray = new string[] { "Apple", "Orange", "Banana", "Kiwi" }; //initializes 2 arrays, of strings and integers
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            List<string> sport = new List<string> { "football", "polo", "running", "swimming", "basketball" };

            Console.WriteLine("Please select an index from the fruit bowl");
            int fruit_index = Convert.ToInt32(Console.ReadLine());

            if(fruit_index > stringArray.Length - 1) //if the index is more than the length of the array -1 it will display the invalid index message
            {
                Console.WriteLine("The index you have selected is not valid");
            }
            else
            {

                Console.WriteLine("You have selected " + stringArray[fruit_index]);
            }

                Console.WriteLine("Please select an index from the number array");
            int num_index = Convert.ToInt32(Console.ReadLine());

            if (num_index > numArray.Length - 1) //if the index is more than the length of the array -1 it will display the invalid index message
            {
                Console.WriteLine("The index you have selected is not valid");
            }
            else
            {

                Console.WriteLine("You have selected " +  numArray[num_index]);
            }
            Console.WriteLine("Please select an index from the sports list");
            int sport_index = Convert.ToInt32(Console.ReadLine());
            if (sport_index > sport.Count - 1) //if the index is more than the count of the list -1 it will display the invalid index message
            {
                Console.WriteLine("The index you have selected is not valid");
            }
            else
            {

                Console.WriteLine("You have selected " + sport[sport_index]);
            }
        }
    }
}
