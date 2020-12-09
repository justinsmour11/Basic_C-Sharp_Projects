using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Justin";
            var age = 31;
            var employee = new Employee("Justin");
            Console.WriteLine(employee.hourWorked);
            Console.ReadLine();
        }
    }
}
