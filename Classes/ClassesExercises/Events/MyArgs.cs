using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class MyArgs: EventArgs
    {
        internal MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
