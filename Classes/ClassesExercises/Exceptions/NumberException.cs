using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NumberException: Exception
    {
        public NumberException(): base("Number error")
        {
            LogNumberException();
        }
        public NumberException(string str)
        {
            Console.WriteLine("{0} Is not a number");
        }
        public NumberException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public static void LogNumberException()
        {
            Console.WriteLine("[Number exception] - The value is negative");   
        }
    }
}
