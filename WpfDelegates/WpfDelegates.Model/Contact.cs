using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfDelegates.Model
{
    /// <summary>
    /// Contact is an entity that represents a new contact
    /// </summary>
	public class Contact
	{
        /// <summary>
        /// Name is a property that contains users name
        /// </summary>
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Telephone { get; set; }
		public string Address { get; set; }
	}
}
