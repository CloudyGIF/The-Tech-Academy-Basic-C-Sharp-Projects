using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main()
        {
            List<int> NumList = new List<int> { 9, 14,16,17,18,20}; //integer list
            

            try
            {
                Console.WriteLine("Please enter a number to divide by"); //try block where the user input integer is storeed
                int divider = Convert.ToInt32(Console.ReadLine());
                foreach (int num in NumList)
                {
                    int result = num / divider;

                    Console.WriteLine(result); //prints division result
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero."); //catches division by 0 error
            }

            catch (FormatException)
            {
                Console.WriteLine("Please insure you are inputting whole numbers."); //catches incorrect format error
            }

            finally
            {
                Console.ReadLine(); //finally block
            }
        }
    }
}
