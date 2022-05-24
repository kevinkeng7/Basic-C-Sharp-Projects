using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                int totalDimension = width + height + length;

                if (totalDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double priceQUote = (totalDimension * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceQUote + ". \n" + "Thank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
