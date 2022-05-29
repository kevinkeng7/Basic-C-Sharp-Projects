using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            Console.WriteLine("List of numbers: 100, 200, 300, 400, 500");
            List<int> userNum = new List<int> { 100, 200, 300, 400, 500 };

            try
            {
                Console.WriteLine("Please enter a number to divide each number in the list by.");
                userNum.ForEach(Console.WriteLine);
                int divisor = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Calculating... Press 'enter' for next number");

                foreach (int number in userNum)
                {
                    int quotient = number / divisor;
                    Console.WriteLine(quotient);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program terminated. Goodbye");
                Console.ReadLine();
            }
            Console.ReadLine();

           

        }
    }
}
