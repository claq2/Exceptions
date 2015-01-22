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
        private readonly ManualResetEvent[] handles = new ManualResetEvent[1] { new ManualResetEvent(false) };

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonThreadException_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadProcedure);
            this.handles[0].Reset();
            thread.Start();
            WaitHandle.WaitAll(this.handles);
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

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
            // Next line is unreachable - I'm just simulating something going wrong before reaching it
            this.handles[0].Set();
        }

        private async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }
    }
}