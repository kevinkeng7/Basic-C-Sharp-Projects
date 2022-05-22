using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int ageNum = Convert.ToInt32(userAge);

            Console.WriteLine("Have you ever had a DUI? Answer true or false.");
            string userDui = Console.ReadLine();


            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticketNum = Convert.ToInt32(ticket);

            bool ageQualify = ageNum > 15;
            bool duiQualify = userDui == "false";
            bool ticketQualify = ticketNum < 3;

            Console.WriteLine("Qualified?");
            bool resultQualify = (ageQualify && duiQualify && ticketQualify);
            Console.WriteLine(resultQualify);

            Console.ReadLine();
           
            //int age = 31;
            //bool hasTicket = true;
            //bool hasPassport = true;
            //bool canFly = (age >= 18 && hasTicket && hasPassport);
            //Console.WriteLine(canFly);
            //Console.ReadLine();


        }
    }
}
