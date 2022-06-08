using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); //Instantiate an Employee object with type "string" as its generic parameter
            employee.Things = new List<string>() { "Thing_1", "Thing_2", "Thing_3", "Thing_4", "Thing_5" }; //Assign a list of strings as the property value of Things.

            Employee<int> employeeNumber = new Employee<int>(); //Instantiate an Employee object with type "int" as its generic parameter
            employeeNumber.Things = new List<int>() { 5, 10, 15, 20, 25 }; //Assign a list of integers as the property value of Things.

            foreach (string thing in employee.Things) //Create a loop that prints all of the Things to the Console.
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }

            foreach (int thing in employeeNumber.Things) //Create a loop that prints all of the Things to the Console.
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
