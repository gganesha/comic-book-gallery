using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                //object initializer syntax
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists() {Name = "Dan Slott", Role = "Script"},
                    new Artists() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artists() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artists() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artists() {Name = "Chris Eliopoulos", Role = "Letters"},
                }

            };

            //comicBook.SeriesTitle = "";
            //when switching from variables to Properties, should capitalize
            /* Not the OPTIMAL Approach
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            */
              
            return View(comicBook);
        }
    }
}