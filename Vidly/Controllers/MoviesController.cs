﻿using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie m = new Movie() { Title = "Avenger 1" };
            return View(m);
        }
    }
}