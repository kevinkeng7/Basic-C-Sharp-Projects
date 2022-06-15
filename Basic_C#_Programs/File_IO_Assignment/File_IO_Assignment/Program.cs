using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number."); //Asks the user for a number.
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\kevinkeng\Logs\number.txt", number);  //Logs that number to a text file.

            string read_number = File.ReadAllText(@"C:\Users\kevinkeng\Logs\number.txt");  //Prints the text file back to the user.
            Console.WriteLine(read_number);
            Console.Read();
        }
    }
}
