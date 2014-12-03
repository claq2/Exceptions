using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace MVC.Controllers
{
    public class ExceptionController : ApiController
    {
        private readonly ManualResetEvent[] handles = new ManualResetEvent[1] { new ManualResetEvent(false) };

        // GET: api/Exception
        public IEnumerable<string> Get()
        {
            throw new Exception("Oh noooo!");
        }

        // GET: api/Exception/5
        public async Task<string> Get(int id)
        {
            await this.AsyncProcedure();
            return "value";
        }

        // POST: api/Exception
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Exception/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Exception/5
        public void Delete(int id)
        {
            var thread = new Thread(ThreadProcedure);
            this.handles[0].Reset();
            thread.Start();
            WaitHandle.WaitAll(this.handles);
        }

        async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
            this.handles[0].Set();
        }
    }
}
