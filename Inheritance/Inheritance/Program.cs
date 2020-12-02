using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", ID=1 };
            //employee1.SayName();
            Employee employee2 = new Employee() { FirstName = "Justin", LastName = "Seymour", ID = 1 };

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
