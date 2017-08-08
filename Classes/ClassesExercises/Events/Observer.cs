using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Observer
    {
        public Pub Subject { get; set; }
        /// <summary>
        /// Sets an instance of subject.
        /// </summary>
        /// <param name="subject">Instance of Pub class.</param>
        public Observer(Pub subject)
        {
            Subject = subject;
        }
        /// <summary>
        /// Subscribes an observer to listen changes in the subject.
        /// </summary>
        public void Subscribe()
        {
            Subject.OnChange += RaiseEvent;
        }
        /// <summary>
        /// UnSubscribes of an observer.
        /// </summary>
        public void UnSubscribe()
        {
            Subject.OnChange -= RaiseEvent;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Current object.</param>
        /// <param name="e">Parameters.</param>
        private void RaiseEvent(object sender, MyArgs e)
        {
            Console.WriteLine("The subject was updated with the next value: {0}", e.Value);
          
        }
    }
}
