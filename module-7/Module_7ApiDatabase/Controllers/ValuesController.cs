using Module_7ApiDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_7ApiDatabase.Controllers
{
    public class ValuesController : ApiController
    {
        CricketerBL cricketerBL = new CricketerBL();
        // GET api/values
        [HttpGet]
        public List<Cricketer> Get(Cricketer cricketer)
        {
            List<Cricketer> cricketers = new List<Cricketer>();
            cricketers = cricketerBL.Get(cricketer);
            return cricketers;
        }

        // GET api/values/5
        [HttpGet]
        [Route("{CricketerId}")]
        public Cricketer Get(int CricketerId)
        {
            Cricketer cricketer = cricketerBL.GetById(CricketerId);
            return cricketer;
        }
        [HttpPost]

        // POST api/values
        public IHttpActionResult Post([FromBody] Cricketer cricketer)
        {
            string result = cricketerBL.Insert(cricketer);
            return Ok(result);
        }
        
        [HttpPut]
        // PUT api/values/5
        [Route("{CricketerId}")]
        public IHttpActionResult Put(int CricketerId,[FromBody] Cricketer cricketer)
        {
            string result = cricketerBL.Update(CricketerId, cricketer);
            return Ok(result);
        }

        [HttpDelete]
        // DELETE api/values/5
        [Route("{CricketerId}")]
        public IHttpActionResult Delete(int CricketerId)
        {
            string result = cricketerBL.Delete(CricketerId);
            return Ok(result);
        }
    }
}
