using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007___Lesson_9.Models;

namespace COMP2007___Lesson_9.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            Album album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}