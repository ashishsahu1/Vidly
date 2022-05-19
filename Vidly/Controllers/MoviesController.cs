using System.Web.Mvc;
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

        public ActionResult ByReleseDate(int year, int month)
        {
            return Content(year + " " + month);
        }
    }


}