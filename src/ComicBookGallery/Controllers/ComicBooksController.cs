using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //content result is a action result type by MVC.
        public ActionResult Detail()
        {
            //to check if today's date

            //RedirectResult() was not used since it cannot implicitly convert type
            //System.Web.Mvc.RedirectResult to System.Web.Mvc.ContentResult
            //Hovering over RedirectResult F12, shows it is an ActionResult
            //Same is found when hovering over ContentResult, shows it is an ActionResult
            //casting wouldn't solve the issue so changed the top to ActionResult
            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");
        }
        /*
         --> Using contentresult to display literal string (ComicBooks/Detail)
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello from the comic books controller!";
            }
        }
        */
        
    }
}