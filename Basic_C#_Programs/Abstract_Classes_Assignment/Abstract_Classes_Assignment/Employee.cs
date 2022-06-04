using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : Person // Create another class called Employee and have it inherit from the Person class.
    {
        public new void SayName() // Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine($"Name: {FirstName} {LastName}"); // First Name Last Name 
        }
    }
}
