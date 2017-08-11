using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashierA = new Cashier("Elias", "Maldonado");
            Console.WriteLine(cashierA);
            var grocerA = new Grocer("Raul", "Rivas");
            Console.WriteLine(grocerA);
        }
    }
}
