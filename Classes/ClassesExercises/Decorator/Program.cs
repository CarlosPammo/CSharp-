using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeBase cBase = new CakeBase();
            Console.WriteLine("Item: {0}, Price: {1}", cBase.GetName(), cBase.GetPrice() );
            
            CreamDecorator creamCake = new CreamDecorator(cBase);
            Console.WriteLine("Item: {0}, Price: {1}", creamCake.GetName(), creamCake.GetPrice());
            

            NameCardDecorator nameCardOnCake = new NameCardDecorator(creamCake);
            Console.WriteLine("Item: {0}, Price: {1}", nameCardOnCake.GetName(), nameCardOnCake.GetPrice());

            Console.ReadLine();
        }
    }
}
