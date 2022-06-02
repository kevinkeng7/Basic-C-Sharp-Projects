using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(); // Inside of the Main method, instantiate and initialize an Employee object
            employee.FirstName = "Sample"; // with a first name of "Sample"
            employee.LastName = "Student"; //and a last name of "Student".
            employee.SayName(); //Call the superclass method SayName() on the Employee object.
            Console.ReadLine();
        }
    }
}
