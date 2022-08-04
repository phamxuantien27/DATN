using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Update.Models;

namespace Update.Controllers
{
    [RoutePrefix("api/MayTinh")]
    public class MayTinhController : ApiController
    {
        public Model1 db = new Model1();
        // GET api/<controller>
        public IEnumerable<MAYTINH> Get()
        {
            MAYTINH mt = new MAYTINH();
            return db.MAYTINHs.ToList();
        }

        // GET api/<controller>/5
        public MAYTINH Get(int id)
        {
            return db.MAYTINHs.Where(x=>x.MaMT==id).FirstOrDefault();
        }
        [Route("HDH/{id:int}")]
        [HttpGet]
        public PHANMEM HDH(int id)
        {
            var mt_pm = db.MT_PM.Where(x => x.MaMT == id && x.LaHDH == true).FirstOrDefault();
            return db.PHANMEMs.Where(x => x.MaPM == mt_pm.PHIENBAN.PHANMEM.MaPM).FirstOrDefault();
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