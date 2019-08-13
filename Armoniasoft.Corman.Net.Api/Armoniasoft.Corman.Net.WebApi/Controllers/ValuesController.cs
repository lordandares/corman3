using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Armoniasoft.Corman.Net.Bussines;
using Armoniasoft.Corman.Net.DataAccess;
using Newtonsoft.Json;

namespace Armoniasoft.Corman.Net.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            InboxMobile inbox = new InboxMobile();
            List<pa_bandeja_usuario_original_fast_Result> inboxList =  inbox.GetInboxMobile(1, 3);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(inboxList), Encoding.UTF8, "application/json");
            response.Headers.CacheControl = new CacheControlHeaderValue();
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
