using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        public static bool ValidateNumber(string number)
        {
            var i = double.Parse(number);
            if (i < 0)
            {
                NumberException.LogNumberException();
                return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
            var valid = false;
            while (!valid)
            {
                Console.Clear();
                Console.Write("Insert a number: ");
                var s = Console.ReadLine();

                try
                {
                    valid = ValidateNumber(s);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NumberException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception ex)
                {
                    throw new NumberException(ex);
                }
                finally
                {
                    Console.WriteLine("Program completed");
                    Console.ReadKey();
                }
            }
        }
    }
}
