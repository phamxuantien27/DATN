using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Update.Models;

namespace Update.Controllers
{
    public class MayTinhController : ApiController
    {
        public Model1 db = new Model1();
        // GET api/<controller>
        public IEnumerable<MAYTINH> Get()
        {
            MAYTINH mt = new MAYTINH();
            mt.PHANMEM.TenPhanMem;
            P
            return db.MAYTINHs.ToList();
        }

        // GET api/<controller>/5
        public MAYTINH Get(int id)
        {
            return db.MAYTINHs.Where(x=>x.MaMT==id).FirstOrDefault();
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