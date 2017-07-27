using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="firstName">Person first name</param>
        /// <param name="lastName">Person last name</param>
        internal Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        protected abstract string GetPermissions();

        public override string ToString()
        {
            return "Person: " + FirstName + " " + LastName + " has permissions to " + GetPermissions();
        }
    }
}
