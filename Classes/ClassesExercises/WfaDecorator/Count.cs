using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WfaDecorator
{
    class Count: Decorator
    {
        Form2 form2 = new Form2();
        //public string CountMessage { get; set; }
        public Count(IComponent component) : base(component)
        {
        }

        public override void DoSomething()
        {
            Component.DoSomething();            
            int count = 0;
            for (int i = 4; i >= count; i--)
            {
                int milliseconds = 1000;
                Thread.Sleep(milliseconds);
                form2.lblCount.Text = i.ToString();
                form2.Show();
                form2.Refresh();
            }
            form2.Close();
        }
    }
}
