using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;
using RouteAttribute = System.Web.Http.RouteAttribute;


namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {

  
        public IHttpActionResult GetCoustomer()
        {
            Coustomer sc = new Coustomer();
            IList<Coustomer> cc = cc = sc.GetRecord();
            return Ok(cc);
        }

        public IHttpActionResult GetCoust(string option)
        {
            Coustomer sc = new Coustomer();
            IList<Coustomer> cc = cc = sc.GetRecordss(option);
            return Ok(cc);
        }

        public IHttpActionResult get(string name)
        {

            Coustomer sc = new Coustomer();
            IList<Coustomer> cc = sc.Search(name);
            return Ok(cc);
        }

        public IHttpActionResult GetCoustomer(int id)
        {
            Coustomer sc = new Coustomer();
            Coustomer cc = sc.show(id);

            return Ok(cc);
        }

              [System.Web.Http.HttpPost]
                // POST api/values
       public IHttpActionResult insert(Coustomer us)
        {
            Coustomer u = new Coustomer();
            u.insert(us);
            return Ok();

        }

        // DELETE api/values/5
        public IHttpActionResult DeleteById(int id)
        {
            Coustomer c = new Coustomer();
            c.Del(id);
            return Ok();
        }
    }
}
