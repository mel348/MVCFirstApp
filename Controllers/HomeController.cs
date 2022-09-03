using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFirstApp.Controllers
                            {                                   /* all of the action methods start with an "I" 
                                                                   the older version of MVC before .Net Core
                                                                   has the same action method names. So they put an
                                                                   "I" to make it unique */
    public class HomeController : Controller                   //HomeController Derived from the Controller Class
    {
        private readonly ILogger<HomeController> _logger;     //For error handling

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string ID)                           //by adding a parameter you can reroute the page      
        {                                                               //to the cit 218 so you can still view the index
            string seeView = ID;                                        //and privacy page on the Home page.
            if (seeView == "cit")
                return View("cit218");                                  //can make the view go anywhere we want by
            else                                                        //adding a new cshtml file in the Home Folder
                return View();                                          //under the Views folder.
        }                                                               
        //GET : Home -----GET Method
        public string myIndex()                                         //Lose menu view, so pass through a view to retain menu
        {
            return "Mel is like the little engine that could! I think I can I think I can!";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
