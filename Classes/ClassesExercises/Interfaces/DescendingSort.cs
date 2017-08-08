using System;
using System.Collections.Generic;

namespace Interfaces
{
    class DescendingSort: ISort
    {
        /// <summary>
        /// Sort a list in descending order.
        /// </summary>
        /// <param name="list">List to order.</param>
        public void Sort(List<string> list)
        {
            list.Reverse();
            Console.WriteLine("Descending sort list");
        }
    }
}
