using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)
                {
                    throw new BelowZeroException();
                }
                int currentYear = 2020;
                int yearBorn = currentYear - age;
                Console.WriteLine("You were born in {0}", yearBorn);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
