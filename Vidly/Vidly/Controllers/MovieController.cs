using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Sherk"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1",},
                new Customer {Name = "Customer2",},
                new Customer {Name = "Customer3",}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
                
            };
           return View(viewModel);
        }

        [Route("movie/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByRelease(int year,int month)
        {
            
            return Content("hola");
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);

        }

        public ActionResult Index()
        {
            var movies = GetMovies();
            

            return View(movies);
        }

        [Route("movie/{id}")]
        public ActionResult MovieDetails(int id)
        {
            
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return new HttpNotFoundResult();
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