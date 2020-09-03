using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        [Route("movie/{id}")]
        public ActionResult Details(int id)
        {
            

            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }



        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Lego" },
                new Movie { Id = 2, Name = "Star Wars" }
            };
        }


    }
}
