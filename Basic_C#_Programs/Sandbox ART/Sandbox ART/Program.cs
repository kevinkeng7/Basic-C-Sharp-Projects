using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_ART
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool result = (true && (true || false));
            bool result = (true ^ true) || (true ^ false);

            //int num1 = 43;
            //int num2 = 37;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is less than num2";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
