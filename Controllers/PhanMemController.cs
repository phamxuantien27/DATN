using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Update.Models;

namespace Update.Controllers
{
    [RoutePrefix("api/PhanMem")]
    public class PhanMemController : ApiController
    {
        public Model1 db = new Model1();
        // GET api/<controller>
        public IEnumerable<PHANMEM> Get()
        {
            return db.PHANMEMs.ToList();
        }

        // GET api/<controller>/5
        public PHANMEM Get(int id)
        {
            return db.PHANMEMs.Where(x=>x.MaPM == id).FirstOrDefault();
        }
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}