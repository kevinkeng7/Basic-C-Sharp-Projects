using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            try // Wrap the statement in a try/catch block
            {
                Console.WriteLine("Enter the current day of the week as a number (0-6)."); // Prompt the user to enter the current day of the week
                string currentday = Console.ReadLine();
                currentday = FirstCharToUpper(currentday); // Convert the first letter to upper case
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentday); // Assign the value to a variable of that enum data type you just created (DaysOfTheWeek)
                Console.WriteLine("You entered: " + day); //display value of day of week user input
                Console.ReadLine();

                string FirstCharToUpper(string input) 
                {
                    if (String.IsNullOrEmpty(input))
                        throw new ArgumentException();
                    return input.First().ToString().ToUpper() + input.Substring(1);

                }
                Console.ReadLine();
            }
            catch (ArgumentException) // Wrap the statement in a try/catch block
            {          
                Console.WriteLine("Please enter an actual day of the week.");

            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek //Create an enum for the days of the week.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
