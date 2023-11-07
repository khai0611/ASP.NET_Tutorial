using ASP.NET_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Tutorial.Controllers
{
    //
    public class HomeController : Controller
    {
        //
        // GET: Home

        public ActionResult Index()
        {
            //Pass data from controller to view: use Model and ViewBag
            ViewBag.WelcomeString = "Welcome to ViewBag";

            var message = new MessageModel(); // create a obj
            message.Welcome = "Welcome to Model"; 
            return View(message);
        }
    }
}

// Note: In ASP.NET MVC, name of Controller must have Controller name at the end
// In controller, have methods that return to Result call is ActionMethod