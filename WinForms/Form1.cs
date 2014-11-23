using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonAsyncException_Click(object sender, EventArgs e)
        {
            await this.AsyncProcedure();
        }

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
        }

        private async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }

        private void buttonException_Click(object sender, EventArgs e)
        {
            throw new Exception("Oh noooo!");
        }

        private void buttonThreadException_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadProcedure);
            thread.Start();
        }
    }
}
