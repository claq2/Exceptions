using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.Controllers
{
    public class BetterExceptionController : ApiController
    {
        // GET: api/BetterException
        public IEnumerable<string> Get()
        {
            var error = new HttpError(new Exception("Oh noooo!"), true);
            throw new HttpResponseException(ControllerContext.Request.CreateErrorResponse
                    (HttpStatusCode.InternalServerError, error));
        }

        // GET: api/BetterException/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BetterException
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BetterException/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BetterException/5
        public void Delete(int id)
        {
        }
    }
}
