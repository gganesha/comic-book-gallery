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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");
    }
    }
}