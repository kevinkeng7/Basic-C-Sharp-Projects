using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jesse = new Employee(); //Employee 1
            Jesse.Id = 007;
            Employee James = new Employee(); //Employee 2
            James.Id = 007;
            bool compare = (Jesse == James);
            if (compare)        //compare Id property of Employee 1 and Employee 2
            {
                Console.WriteLine("Employee IDs match"); //if match
            }
            else
            {
                Console.WriteLine("Employee IDs do not match"); //if do not match
            }
            Console.ReadLine();
        }
    }
}
