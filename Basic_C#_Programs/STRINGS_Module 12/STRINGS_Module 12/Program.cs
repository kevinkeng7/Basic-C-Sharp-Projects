using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGS_Module_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            string name = "jesse";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            string name = "jesse";
            name = name.ToLower();
            Console.WriteLine(name);
            Console.ReadLine();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string userName = "<Type your name here>";
            //string dateString = DateTime.Today.ToShortDateString();

            //// Use the + and += operators for one-time concatenations.
            //string str = "Hello " + userName + ". Today is " + dateString + ".";
            //Console.WriteLine(str);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Jesse");
            //Console.WriteLine(sb);
            //Console.ReadLine();


        }
    }
}
