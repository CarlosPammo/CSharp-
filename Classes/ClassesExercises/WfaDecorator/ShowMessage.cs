using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaDecorator
{
    class ShowMessage: Decorator
    {
        public ShowMessage(IComponent component) : base(component)
        {
        }

        public override void DoSomething()
        {
            Component.DoSomething();
            MessageBox.Show(@"Hi, this is a new message.");
        }
    }
}
