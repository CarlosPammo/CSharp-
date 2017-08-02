using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaDecorator
{
    abstract class Decorator: IComponent
    {
        public IComponent Component { get; set; }

        protected Decorator(IComponent component)
        {
            Component = component;
        }

        public abstract void DoSomething();
    }
}
