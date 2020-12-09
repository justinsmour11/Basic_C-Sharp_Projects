using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    public class Employee
    {
        public Employee(string name) : this(name, 40)
        {

        }
        public Employee(string name, int hours)
        {
            Name = name;
            hourWorked = hours;
        }
        public string Name { get; set; }
        public int hourWorked { get; set; }
    }
}
