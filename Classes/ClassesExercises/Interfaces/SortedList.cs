using System;
using System.Collections.Generic;

namespace Interfaces
{
    class SortedList
    {
        private readonly List<string> list = new List<string>();
        private ISort sortStrategy;

        /// <summary>
        /// Sets a strategy.
        /// </summary>
        /// <param name="strategy">Instance of the strategy selected.</param>
        public void SetSortStrategy(ISort strategy)
        {
            sortStrategy = strategy;
        }

        /// <summary>
        /// Adds a new name in the list.
        /// </summary>
        /// <param name="name">Name to insert in the list.</param>
        public void Add(string name)
        {
            list.Add(name);
        }

        /// <summary>
        /// Shows the items of the list.
        /// </summary>
        public void Sort()
        {
            sortStrategy.Sort(list);

            foreach (var name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
