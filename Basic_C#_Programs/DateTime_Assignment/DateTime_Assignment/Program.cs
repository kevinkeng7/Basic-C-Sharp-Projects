using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now; //Prints the current date and time to the console.
            Console.WriteLine(dateTime);

            Console.WriteLine("Input a number. This will be # of hours added to current time"); //Asks the user for a number.
            int X = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime1 = dateTime.AddHours(+X); //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine(dateTime1);
            Console.Read();

        }
    }
}
