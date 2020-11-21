using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAMathApp
{
    class Program
    {
        static void Main()
        {
            string userInput1 = Console.ReadLine();
            int userNum = Convert.ToInt32(userInput1);
            int timesFifty = userNum * 50;
            Console.WriteLine(timesFifty);

            string userInput2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userInput2);
            int plusTwentyFive = userNum2 + 25;
            Console.WriteLine(plusTwentyFive);
            
            string userInput3 = Console.ReadLine();
            int userNum3 = Convert.ToInt32(userInput3);
            float divide = userNum3 / 12.5f;
            Console.WriteLine(divide);

            string userInput4 = Console.ReadLine();
            int userNum4 = Convert.ToInt32(userInput4);
            bool aboveFifty = userNum4 > 50;
            Console.WriteLine(aboveFifty);

            string userInput5 = Console.ReadLine();
            int userNum5 = Convert.ToInt32(userInput5);
            int remainder = userNum5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
