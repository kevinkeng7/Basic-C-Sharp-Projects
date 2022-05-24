using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_Statements_Loops_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //int day = 2;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            //Console.ReadLine();


            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;


            do // do while loop
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
        //while // while loop
        //    {
        //        switch (number)
        //        {
        //            case 62:
        //                Console.WriteLine("You guessed 62. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 29:
        //                Console.WriteLine("You guessed 29. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 55:
        //                Console.WriteLine("You guessed 55. Try again.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 12:
        //                Console.WriteLine("You guessed the number 12. That is correct!");
        //                isGuessed = true;
        //                break;
        //            default:
        //                Console.WriteLine("You are wrong.");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //        }
        //    }
        //    Console.Read();
        //}
                   
    }
}
