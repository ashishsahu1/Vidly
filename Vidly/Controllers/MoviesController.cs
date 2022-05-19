using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie m = new Movie() { Title = "Avenger 1" };
            return View(m);
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


        //Action Parameters Demo
        public ActionResult Edit(int id)
        {
            return Content("ID = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 111;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name2";

            return Content(string.Format(pageIndex + " " + sortBy));
        }

        //Convention way of Route 
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("This is Convention way of routing " + year + " " + month);
        }

        //Attribute Routing with ":" used for setting constraints on a part of url
        [Route("movies/released2/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate2(int year, int month)
        {
            return Content("This is attribute way of routing " + year + " " + month);
        }


        //Demonstrating ViewModel
        public ActionResult GetMoviesAndCustomer()
        {
            Movie movie = new Movie() { Title = "Avengers: End Game" };
            List<Customer> CustomerLst = new List<Customer>()
            {
                new Customer(){Name = "Ashish"},
                new Customer(){Name = "Ishu"}
            };

            MovieCustomerViewModel MovieCusotmerVM = new MovieCustomerViewModel()
            {
                movie = movie,
                Customers = CustomerLst
            };
            return View(MovieCusotmerVM);
        }

    }


}