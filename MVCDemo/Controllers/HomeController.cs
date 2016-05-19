﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*Takes care of the logic for the Home page. 
These methods (Index, About, and Contact) within our Controller are called 
“Controller Actions”, and their job is to respond to URL requests 
and (generally speaking) determine what content should be sent back to the browser or user that invoked the URL.
The route is determined by the RouteConfig, and right now it points like this

    Home/Index
    Home/About
    Home/Contact

The route name gets its name from the first word in whatever controller it is: HomeController. 
     */
    

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}