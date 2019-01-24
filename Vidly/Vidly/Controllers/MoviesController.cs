using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [HttpGet]
        public ActionResult Random()
        {
            var Movie = new Movie()
            {
                Name = "Shrek"
            };
            //return View(Movie);
            //return Content("hello world");
            //return HttpNotFound();
            return View(Movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id.ToString());
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace((sortBy)))
            {
                sortBy = "Name";
            }

            return Content(string.Format("PageIndex={0},sortBy={1}", pageIndex, sortBy));
        }
    }
}