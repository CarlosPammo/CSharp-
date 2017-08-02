using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaDecorator
{
    public partial class Form1 : Form
    {
        private OpenWindow OpenWindow { get; set; }
        private ShowMessage ShowMessage { get; set; }
        private Count Count { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void cbOpenWindow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            IComponent cBase = new ConcretComponent();
            if (cbOpenWindow.Checked)
            {
                cBase = new OpenWindow(cBase);
            }

            if (cbCount.Checked)
            {
                cBase = new Count(cBase);
            }

            if (cbMessage.Checked)
            {
                cBase = new ShowMessage(cBase);
            }
            cBase.DoSomething();
        }

    }
}
