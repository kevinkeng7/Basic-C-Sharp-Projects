using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment1to6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Jesse Erik Daniel Adam");


            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //Console.WriteLine("Enter a name.");
            //string arrayName = Console.ReadLine();

            //Console.WriteLine("Adding your answer to the strings " + arrayName);


            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j] + arrayName);
            //}
            //Console.ReadLine();

            //creating an infinite loop using while loop
            //while (true)
            //{
            //    Console.WriteLine("This is an infinite loop");
            //}

            //fixing an infinite loop
            //int num1 = 32;
            //int num2 = 64;


            //if (num1 > num2)
            //{
            //    Console.WriteLine("num1 is greater than num2");
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine("num1 is less than num2");
            //}
            //else if (num1 <= num2)
            //{
            //    Console.WriteLine("num1 is less than or equal to num2");
            //}
            //else
            //{
            //    Console.WriteLine("none of the above");
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //Console.WriteLine("Input a name to search for in the list");

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.Read();

            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

            //Console.WriteLine("Guess my height?");
            //int height = Convert.ToInt32(Console.ReadLine());
            //bool myHeight = height == 180;

            //while (!myHeight)
            //{
            //    switch (height)
            //    {
            //        case int n when (n < 168 && n > 165):
            //            Console.WriteLine("I am taller! Try again");
            //            Console.WriteLine("Guess my height again?");
            //            height = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case int n when (n < 175 && n > 168):
            //            Console.WriteLine("I am not that tall! Try again");
            //            Console.WriteLine("Guess my height again?");
            //            height = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 180:
            //            Console.WriteLine("You guessed my height correctly!");
            //            myHeight = true;
            //            break;
            //        default:
            //            Console.WriteLine("Your guess is not correct.");
            //            Console.WriteLine("Guess my height again?");
            //            height = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" }; 

            //for (int j = 0; j < names.Length; j++)
            //{
            //   Console.WriteLine(names[j]);  //print each name above to console, each name in a new line
            //}
            //Console.ReadLine();

            //    List<int> testScores = new List<int>();
            //    testScores.Add(98);
            //    testScores.Add(99);
            //    testScores.Add(81);
            //    testScores.Add(72);
            //    testScores.Add(70);

            //    foreach (int score in testScores)
            //    {
            //        if (score > 85)
            //        {
            //            Console.WriteLine("Passing test score: " + score);
            //        }
            //    }
            //    Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();

        }
    }
}
