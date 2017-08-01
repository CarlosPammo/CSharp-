using System;
using System.Threading;
using System.Windows.Forms;

namespace DynamicLinqWFA
{
    public partial class Form1 : Form
    {
        public LoadingMessageBox MessageBox { get; set; }
        public Form1()
        {
            InitializeComponent();
            var propertiesToBeListed = typeof (Shampoo).GetProperties();
            foreach (var propertyInfo in propertiesToBeListed)
            {
                CbField.Items.Add(propertyInfo.Name);
            }
            CbOperation.Items.Add("Equals to");
            CbOperation.Items.Add("Different than");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TbCriteria.Text.Equals("") || CbOperation.Text.Equals("") || CbField.Text.Equals(""))
            {
                throw new Exception("Please, all fields should have a value");
            }

            const int minimun = 4;
            MessageBox = new LoadingMessageBox(minimun.NextRand());
            MessageBox.Show();
            MessageBox.ClosingDialog += ClosingDialog;

        }

        private void ClosingDialog(int time)
        {
            searchPro();
        }

        private void searchPro()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(searchPro));
                return;
            }
            var shampoos = ProductAccess.SearchShampoos(TbCriteria.Text, CbOperation.Text, CbField.Text);
            DgShampoos.DataSource = shampoos;
            MessageBox.Close();
            MessageBox = null;
        }
    }
}
