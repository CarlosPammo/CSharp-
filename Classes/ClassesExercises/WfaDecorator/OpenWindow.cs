using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaDecorator
{
    class OpenWindow: Decorator
    {
        public OpenWindow(IComponent component) : base(component)
        {
        }

        public override void DoSomething()
        {
            Component.DoSomething();
            var myForm = new Form();
            myForm.Show();
        }
    }
}
