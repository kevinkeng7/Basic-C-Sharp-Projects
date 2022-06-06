using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public abstract class Person
    {
        public string FirstName { get; set; } // Create an abstract class called Person with two properties: string firstName
        public string LastName { get; set; } // and string lastName.

        public void SayName() // Give it the method SayName().
        {
            Console.WriteLine($"Name: {FirstName} {LastName}"); // First Name Last Name format.
        }
    }
}