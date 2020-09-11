using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MoviesController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(_mapper.Map<Movie,MovieDto>);
        }

        [Route("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Movie, MovieDto>(movie));
        }

        [HttpPost]
        public IActionResult CreateMovie(MovieDto movieDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie =  _mapper.Map<MovieDto, Movie>(movieDto);
            _context.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(Request.Path + "/" + movie.Id,movieDto);

        }

        [Route("{id}")]
        [HttpPut]
        public void UpdateMovie(int id ,MovieDto movieDto)
        {
            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDB == null)
            {
                throw new HttpRequestException(NotFound().ToString());
            }

            if (!ModelState.IsValid)
            {
                throw  new HttpRequestException(BadRequest().ToString());
            }

            _mapper.Map(movieDto,movieInDB);
            _context.SaveChanges();

        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());
            }

            _context.Remove(movie);
            _context.SaveChanges();

        }




    }
}
