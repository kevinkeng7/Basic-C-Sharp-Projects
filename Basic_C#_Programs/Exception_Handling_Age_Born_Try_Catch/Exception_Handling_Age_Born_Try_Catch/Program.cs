using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Age_Born_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What year were you born?"); //Display the year the user was born.
                int yearBorn = Convert.ToInt32(Console.ReadLine());
                if (yearBorn <= 0) // check if user enters zero or negative numbers
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("You were born in: {0}", yearBorn); //display year user born
                var today = DateTime.Today;
                var age = today.Year - yearBorn;
                Console.WriteLine("Your age is: {0}", age);
                Console.ReadLine();
            }
            catch (ArgumentException) //Display error message if user enters zero or negative numbers
            {
                Console.WriteLine("Please enter a number greater than 0 in a valid year format.");
                Console.ReadLine();
                return;
            }
            catch (Exception) //Display general error message if exception was caused by anything else
            {
                Console.WriteLine("An error has occurred. Please contact your System Admin.");
                Console.ReadLine();
                return;
            }
        }
    }
}
