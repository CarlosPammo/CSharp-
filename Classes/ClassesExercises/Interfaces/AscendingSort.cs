using System;
using System.Collections.Generic;

namespace Interfaces
{
    class AscendingSort: ISort
    {
        /// <summary>
        /// Sort a list in ascending order.
        /// </summary>
        /// <param name="list">List to order.</param>
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Ascending sort list");
        }
    }
}
