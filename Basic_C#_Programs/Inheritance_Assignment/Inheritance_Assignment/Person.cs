using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Person //Create a class called Person and give it 2 properties, each of data type string:
    {
        public string FirstName { get; set; } //One called FirstName, 
        public string LastName { get; set; } //the other LastName.

        public void SayName() //Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
