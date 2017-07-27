using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    class Cashier: Person
    {
        internal Cashier(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        /// <summary>
        /// Gets a permission that have a cashier.
        /// </summary>
        /// <returns>Permission</returns>
        protected override string GetPermissions()
        {
            return "sales";
        }
    }
}
