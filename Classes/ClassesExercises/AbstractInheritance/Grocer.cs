using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    class Grocer: Person
    {
        internal Grocer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        /// <summary>
        /// Gets a permission that have a grocer.
        /// </summary>
        /// <returns>Permission</returns>
        protected override string GetPermissions()
        {
            return "warehouse";
        }
    }
}
