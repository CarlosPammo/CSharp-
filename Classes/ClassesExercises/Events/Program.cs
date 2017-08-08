using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Pub(5);
            var observerOne = new Observer(subject);
            var observerTwo = new Observer(subject);

            Console.WriteLine("** Subscribing two observers **");
            observerOne.Subscribe();
            observerTwo.Subscribe();
            subject.NotifyObservers();
            Console.WriteLine();
            Console.WriteLine("-- UnSubscribing one observer and updating the value in the subject --");
            subject.Value = 4;
            observerOne.UnSubscribe();
            subject.NotifyObservers();
            Console.ReadKey();
        }
    }
}
