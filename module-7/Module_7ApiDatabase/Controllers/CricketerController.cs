using Module_7ApiDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_7ApiDatabase.Controllers
{
    public class CricketerController : ApiController
    {
        CricketerBL cricketerBL = new CricketerBL();
        /// <summary>
        /// Get method to get list of all cricketers
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>List of Cricketers</returns>
        [HttpGet]
        public List<Cricketer> Get(Cricketer cricketer)
        {
            List<Cricketer> cricketers = new List<Cricketer>();
            cricketers = cricketerBL.Get(cricketer);
            return cricketers;
        }

        /// <summary>
        /// Get By Id method to get one cricketer record
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>A Cricketer record</returns>
        [HttpGet]
        [Route("{CricketerId}")]
        public Cricketer Get(int CricketerId)
        {
            Cricketer cricketer = cricketerBL.GetById(CricketerId);
            return cricketer;
        }
        [HttpPost]

        /// <summary>
        /// POST method to get list of all cricketers
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>HTTP Action OK by getting result string of success</returns>
        public IHttpActionResult Post([FromBody] Cricketer cricketer)
        {
            string result = cricketerBL.Insert(cricketer);
            return Ok(result);
        }


        /// <summary>
        /// Update method to modify cricketer record by Id
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>HTTP Action OK by getting result string of success</returns>
        [HttpPut]
        [Route("{CricketerId}")]
        public IHttpActionResult Put(int CricketerId,[FromBody] Cricketer cricketer)
        {
            string result = cricketerBL.Update(CricketerId, cricketer);
            return Ok(result);
        }


        /// <summary>
        /// Delete method to delete cricketer record by Id
        /// </summary>
        /// <param name="cricketer"></param>
        /// <returns>HTTP Action OK by getting result string of success</returns>
        [HttpDelete]        
        [Route("{CricketerId}")]
        public IHttpActionResult Delete(int CricketerId)
        {
            string result = cricketerBL.Delete(CricketerId);
            return Ok(result);
        }
    }
}
