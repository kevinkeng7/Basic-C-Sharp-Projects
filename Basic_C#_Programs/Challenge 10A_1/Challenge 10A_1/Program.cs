using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_10A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jessie");
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is " + name);
            //}
            //Console.ReadLine();

            //if (1 != 2)
            //{
            //    Console.WriteLine("All is right with the universe.");
            //}
            //else
            //{ 
            //    Console.WriteLine("We live in a bizarro world.");
            //}
            //Console.ReadLine();


            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            
            if (userAge < 20)
            {
                Console.WriteLine("No you may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("There you go!");
            }
            Console.ReadLine(); 
        }
    }
}
