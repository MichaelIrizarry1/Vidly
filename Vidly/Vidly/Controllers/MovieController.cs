using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Sherk"};
            return View(movie);
        }
    }
}