using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_database.Data;
using movie_database.Models;

namespace movie_database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie_detailsController : ControllerBase
    {
        private readonly movie_databaseContext _context;

        public Movie_detailsController(movie_databaseContext context)
        {
            _context = context;
        }

        // GET: api/Movie_details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_details>>> GetMovie_details()
        {
            return await _context.Movie_details.ToListAsync();
        }

        // GET: api/Movie_details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_details>> GetMovie_details(int id)
        {
            var movie_details = await _context.Movie_details.FindAsync(id);

            if (movie_details == null)
            {
                return NotFound();
            }

            return movie_details;
        }

        // PUT: api/Movie_details/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_details(int id, Movie_details movie_details)
        {
            if (id != movie_details.Movie_ID)
            {
                return BadRequest();
            }

            _context.Entry(movie_details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_detailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movie_details
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Movie_details>> PostMovie_details(Movie_details movie_details)
        {
            _context.Movie_details.Add(movie_details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_details", new { id = movie_details.Movie_ID }, movie_details);
        }

        // DELETE: api/Movie_details/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie_details>> DeleteMovie_details(int id)
        {
            var movie_details = await _context.Movie_details.FindAsync(id);
            if (movie_details == null)
            {
                return NotFound();
            }

            _context.Movie_details.Remove(movie_details);
            await _context.SaveChangesAsync();

            return movie_details;
        }

        private bool Movie_detailsExists(int id)
        {
            return _context.Movie_details.Any(e => e.Movie_ID == id);
        }
    }
}
