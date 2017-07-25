using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        public static void DisplayLines()
        {
            Console.WriteLine("------------------------------------");
        }
        static void Main(string[] args)
        {
            var ceramidas = new Product("Ceramidas");
            const int codeShampooFactory = 3;
            ceramidas.SetShampooFactory(codeShampooFactory);
            Console.WriteLine(ceramidas);
            DisplayLines();
            var nutrilon = new Product("Nutrilon");
            const int codeMilkFactory = 1;
            nutrilon.SetMilkFactory(codeMilkFactory);
            Console.WriteLine(nutrilon);
            DisplayLines();
        }
    }
}
