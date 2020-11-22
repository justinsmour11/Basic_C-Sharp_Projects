using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello.";
            string str2 = "My name ";
            string str3 = "is Justin.";

            string combinedStr = str1 + str2 + str3;

            string upperStr = combinedStr.ToUpper();
            Console.WriteLine(upperStr);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Welcome, Dear Reader");
            sb.Append("I wasn't yelling at you. If you're reading this, you have found one of my C# projects. ");
            sb.Append("I'm using the StringBuilder class to build this string one sentence at a time. ");
            sb.Append("This is the second-to-last sentence. Thank you for stopping by.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
