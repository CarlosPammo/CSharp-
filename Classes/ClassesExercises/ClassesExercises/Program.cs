using System;

namespace ClassesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Product zucaritas = new Product("Zucaritas", "Kellogs");
            Shampoo shampoo = new Shampoo("Ceramidas", "Sedal");

            Console.WriteLine(zucaritas);
            Console.WriteLine(shampoo);
        }
    }
}
