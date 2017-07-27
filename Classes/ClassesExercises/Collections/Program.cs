using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new LinkedList();
            firstList.Add("Hello");
            firstList.Add("World");

            foreach (var node in firstList)
            {
                Console.WriteLine(node);
            }
        }
    }
}
