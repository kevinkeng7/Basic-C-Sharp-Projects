using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number(); //In the Main() method, create an object of data type Number
            number.Amount = 777; //assign an amount to it.
            Console.WriteLine(number.Amount); //Print this amount to the console.
            Console.ReadLine(); 

        }

        public struct Number //Create a struct called Number
        {
            public decimal Amount { get; set; } //give it the property "Amount" and have it be of data type decimal.
            
        }
        
    }
}
