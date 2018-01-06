using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "HappyGilmore!" };
            return View(movie);
        }

        // GET: Edit?id='id'
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
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