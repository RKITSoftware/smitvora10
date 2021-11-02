using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstWebApiProject.Controllers
{

    [ApiController]
    //Routing done for all methods in controller
    [Route("api/[controller]")]
    public class CricketerController : Controller
    {
        //readonly object of ApplicationDbContext class
        private readonly ApplicationDbContext _db;

        //db object of ApplicationDbContext class which is made with the help of dependency injection
        public CricketerController(ApplicationDbContext db)
        {
            //assigning db to _db tobe used in controller
            _db = db;
        }
        //get method to get records of cricketers
        [HttpGet]
        public IEnumerable<Cricketer> Get()
        {
            IEnumerable<Cricketer> objList = _db.Cricketer;
            return objList;
        }

        //get method to get a cricketer according to the Id
        [HttpGet]
        [Route("cricketers/{id}")]
        public Cricketer Get(int id)
        {
            Cricketer objCricketer = _db.Cricketer.Find(id);
            if (objCricketer!=null)
            {
                return objCricketer;
            }
            else
            {
                objCricketer.CricketerName = "No Cricketer Name Found";
                objCricketer.Team = "No Team Found";
                return objCricketer;
            }

        }

        //get method showing another characteristic according to the Id
        [HttpGet]
        //Attribute routing done for this method.
        [Route("cricketers/{id}/IplTeams")]
        public string GetIplTeams(int id)
        {          
            
            if (id == 1)
            {                
                return "plays for RCB in IPL";
            }
            if (id == 2)
            {
                return "plays for MI in IPL";
            }
            if (id == 3)
            {
                return "plays for DC in IPL";
            }
            if (id == 4)
            {
                return "plays for KKR in IPL";
            }
            else
            {
                return  "plays for CSK in IPL";
            }
        }

        //Post method to add cricketer object in the database using HttpPost
        [Route("AddCricketer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IEnumerable<Cricketer> Post(Cricketer objCricketer)
        {
            _db.Add(objCricketer);
            _db.SaveChanges();
            return _db.Cricketer;
        }

        //Update a record in database using HttpPut
        [Route("UpdateCricketer/{id}")]
        [HttpPut]        
        //Parameter usage for getting cricketer object
        public Cricketer Update(int id, [FromBody]Cricketer cricketer)
        {
            Cricketer objCricketer = _db.Cricketer.Find(id);
            if (objCricketer!=null)
            {
                objCricketer.CricketerName = cricketer.CricketerName;
                objCricketer.Team = cricketer.Team;
                
                _db.SaveChanges();
                return objCricketer;
            }
            else
            {
                objCricketer.CricketerName = "No Cricketer Name Found";
                objCricketer.Team = "No Team Found";
                return objCricketer;
            }

            
        }

        //Delete a record in database using HttpDelete
        [Route("DeleteCricketer/{id}")]
        [HttpDelete]
        public IEnumerable<Cricketer> Delete(int id)
        {
            Cricketer objCricketer = _db.Cricketer.Find(id);
            if (objCricketer != null)
            {
                _db.Cricketer.Remove(objCricketer);
                _db.SaveChanges();
            }

            return _db.Cricketer;
        }
    }
}
