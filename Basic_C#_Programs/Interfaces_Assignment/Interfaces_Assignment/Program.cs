using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Inside the Main() method, instantiate an Employee object
            employee.FirstName = "Sample"; // with firstName "Sample" 
            employee.LastName = "Student"; // and lastName "Student"
            employee.SayName(); // Call the SayName() method on the object.
            employee.Quit(); // inheritance

            IQuittable instance = new XQuit(); //new instance of the quit method
            instance.Quit();
            Console.ReadLine();
        }
    }
}
