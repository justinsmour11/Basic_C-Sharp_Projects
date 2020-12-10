using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptions
{
    public class BelowZeroException : Exception
    {
        public BelowZeroException()
        { 
            Console.WriteLine("Your age must be above zero!");
            Console.Read();
        }
    }
}
