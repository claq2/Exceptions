using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
        }

        private async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }

        protected void ButtonThreadException_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadProcedure);
            thread.Start();
        }

        protected async void ButtonAsyncException_Click(object sender, EventArgs e)
        {
            await this.AsyncProcedure();
        }

        protected void ButtonThreadpoolException_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(ThreadProcedure);
        }

        protected void ButtonException_Click(object sender, EventArgs e)
        {
            throw new Exception("Oh noooo!");
        }
    }
}