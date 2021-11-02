using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        //list of cricketers
        public List<Cricketer> cricketers = new List<Cricketer>
        {
            new Cricketer{CricketerName="Virat Kohli", Team="India"},
            new Cricketer{CricketerName="Rohit Sharma", Team="India"},
            new Cricketer{CricketerName="Steve Smith", Team="Australia"},
            new Cricketer{CricketerName="Pat Cummins", Team="Australia"},

        };
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }
        //get method to show list elements in the view
        public IActionResult Index()
        {
            return View(cricketers);
        }

        //Routing to the add cricketer view to add fields for an element of the list
        public IActionResult AddCricketer()
        {
            return View();
        }

        //POST method to add cricketer object in the list which we we get from thew user.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCricketer(Cricketer objCricketer)
        {
            cricketers.Add(objCricketer);

            //After adding cricketer it redirects back to the index view of index method.
            return Ok(Index());

        }


    }
}
