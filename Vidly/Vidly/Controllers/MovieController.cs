using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        

        [Route("movie/{id}")]
        public ActionResult Details(int id)
        {
            

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [Route("Movie/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            var viewModel = new MoviesEditViewModel()
            {
                Genre = _context.Genre,
                Movie = movie
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            var movieToUpdate = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);
            if (movieToUpdate == null)
            {
                return NotFound();
            }

            movieToUpdate.Name = movie.Name;
            movieToUpdate.DateAdded = movie.DateAdded;
            movieToUpdate.NumberInStock = movie.NumberInStock;
            movieToUpdate.ReleaseDate = movie.ReleaseDate;
            movieToUpdate.GenreId = movie.GenreId;

            _context.SaveChanges();

            return RedirectToAction("index","Movie");
        }
        [Route("Movie/New")]
        public ActionResult New()
        {
            var viewModel = new MoviesCreateViewModel()
            {
                Genres = _context.Genre
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                var viewModel = new MoviesCreateViewModel()
                {
                    Name = movie.Name,
                    DateAdded = movie.DateAdded,
                    ReleaseDate = movie.ReleaseDate,
                    NumberInStock = movie.NumberInStock,
                    GenreId = movie.GenreId,
                    Genres = _context.Genre
                    
                };

                return View("New",viewModel);
                
            }
            else
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index", "Movie");
            }

        }



        


    }
}
