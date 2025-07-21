using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterate_Assignments
{
    internal class Program
    {
        static void Main()
        {
            //Assignment Part 1

            string[] Count = new string[] { "one", "two", "three", "four" }; //initialises a string array 
            Console.WriteLine("Please enter your favoutire animal");
            string animal = Console.ReadLine(); //gets user input

            for (int i = 0; i < Count.Length; i++)
            {
                Count[i] = Count[i] + " " + animal; //modifies each string in the array to be itself + space + user input
            };


            for (int i = 0; i < Count.Length; i++)
            {
                Console.WriteLine(Count[i]); //print every string in the array
            };

            //Assignment Part 2

            int[] Nums = new int[] { 1, 2, 3, 4, 5 };

            //for (int i = 0;i < Nums.Length;)
            //{
            //Console.WriteLine(Nums[i]);
            //}
            //This creates an infinite loop because the i incrementation statement is missing from the for paratmeters, it prints Nums[0] infinetly



            for (int i = 0; i < Nums.Length; i++)
            {
                Console.WriteLine(Nums[i]);
            }

            //this prints all indecies in the array once and finishes the loop


            //Assignment Part 3

            int[] Nums2 = new int[] { 10, 12, 13, 14, 15 };
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums2[i] < 14) { Console.WriteLine(Nums2[i]); }; //if Nums2[i] is greater less than 14, it gets printed in the console
            }
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums2[i] <= 14) { Console.WriteLine(Nums2[i]); }
                ; //if Nums2[i] is less than or equals 14, it gets printed in the console
            }

            //Assignment Part 4

            List<string> FruitList = new List<string> { "apple", "banana", "strawberry", "pear", "pineapple" }; //list is initialized

            bool guessed = false; //win condition is initialized 

            do
            {

                Console.WriteLine("Please guess a fruit");
                string fruit_guess = Console.ReadLine(); //question is asked, input is stored



                foreach (var fruit in FruitList)
                {

                    if (fruit == fruit_guess)
                    {
                        Console.WriteLine("Your chosen fruit index is " + FruitList.IndexOf(fruit)); //if the fruit is equal to the input by the user, the index of that input is printed

                        guessed = true; //win condition is activated

                        break; //loop is broken
                    }
                }

                if (guessed == false)
                {
                    Console.WriteLine("The fruit you have chosen is not on the list! Please try again.");
                }
            } while (guessed == false); //the loop will continue while guessed is false

            //Assignment Part 5

            List<string> VegList = new List<string> { "cucumber", "eggplant", "tomato", "cucumber", "potato" }; //list is initialzied 

            Console.WriteLine("Please guess a vegetable");
            string veg_guess = Console.ReadLine(); //input is stored

            bool contains = false; //win condition is initialized 

            int index = 0; //index of the list

            foreach (var veg in VegList)
            {
                if (veg == veg_guess)
                {
                    Console.WriteLine("Your chosen fruit index is " + index); //if there is a match index gets printed and win condition is triggered
                    contains = true;
                }
                index++; //increments index by 1 for the next loop run 
            }

            if(contains == false)
            {
                Console.WriteLine("The vegetable you have chosen is not on the list!"); //if there have been no matches the text is printed
            }

            //Assignment Part 6

            List<string> DrinkList = new List<string> { "cola", "coffee", "tea", "juice", "cola" }; //list is initialzied 

            for (int i = 0; i < DrinkList.Count; i++) //outer loop is initialised 
            {
                int matched = 0; //matched count
                for (int j = 0;  j < i; j++) //inner loop initialized, it does not go though the entire array, but only until the index of the outer loop
                {
                    if (DrinkList[i] == DrinkList[j]) 
                    {
                        matched++; //if there is match count is incremented by 1
                    }
                }

                if (matched == 0) //if there were no matches the item is unique, if not then its a duplicate
                {
                    Console.WriteLine(DrinkList[i] + " - this item is unique!");
                }
                else
                {
                    Console.WriteLine(DrinkList[i] + " - this item is a duplicate!");
                }
            }    
        }
    }
}
