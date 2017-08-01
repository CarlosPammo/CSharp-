using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicLinqWFA
{
    public partial class LoadingMessageBox : Form
    {
        public Thread testThread { get; set; }

        public delegate void OnClosing(int time);

        public event OnClosing ClosingDialog;

        private int Time { get; }

        public LoadingMessageBox(int time)
        {
            Time = time;
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            var thread = new Thread(() =>
            {
                var counter = Time;
                while (counter > 0)
                {
                    Refresh(counter);
                    Thread.Sleep(1000);
                    counter--;
                }
                ClosingDialog?.Invoke(Time);
            });
            thread.Start();
        }

        private void Refresh(int counter)
        {
            LblText.Text = $"Loading in ({counter})";
            LblText.Refresh();
        }

        private void LoadingMessageBox_Load(object sender, EventArgs e)
        {
        }
    }
}
