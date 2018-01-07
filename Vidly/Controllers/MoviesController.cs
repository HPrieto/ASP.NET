using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "HappyGilmore!" };
            var customers = new List<Customer>
            {
                new Customer(){Name="Customer 1"},
                new Customer(){Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //ViewData["Movie"] = movie;  DO NOT USE
            //ViewBag.Movie = movie;      DO NOT USE
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
/* View Result           -> View()
 * PartialViewResult     -> PartialView()
 * ContentResult         -> Content()
 * RedirectResult        -> Redirect()
 * RedirectToRouteResult -> RedirectToAction()
 * JsonResult            -> Json()
 * FileResult            -> File()
 * HttpNotFoundResult    -> HttpNotFound()
 * EmptyResult (Nothing needs to be found.)
 * */