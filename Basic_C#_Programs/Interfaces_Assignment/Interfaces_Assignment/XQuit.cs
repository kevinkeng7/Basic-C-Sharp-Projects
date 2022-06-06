using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public class XQuit : IQuittable     //polymorphism to create an object of type IQuittable + call the Quit() method on it
    {
        public void Quit()
        {
            Console.WriteLine("I Quit.");

        }
    }
}
