using System;


namespace Shipping_Quote
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n Please enter the package weight:"); //Greeting
            int weight = Convert.ToInt32(Console.ReadLine()); //gets the weight num and casts to int

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else 
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dim = width + height + length;
                if (dim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else 
                {
                    int quote = ((width * height * length) * weight)/100;
                    string quote_final = quote.ToString("0.00");
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote_final);
                }
            }
        }
    }
}
