using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public class Employee : Person, IQuittable //Have your Employee class inherit that interface + implement the Quit() method
    {

        public new void SayName() // Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine($"Name: {FirstName} {LastName}"); 
        }

        public void Quit()
        {
            Console.WriteLine("I Quit.");
            Console.ReadLine();
        }

    }
}
