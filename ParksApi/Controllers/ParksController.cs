using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private readonly ParksApiContext _context;

        public ParksController(ParksApiContext context)
        {
            _context = context;
        }

        // GET: api/Parks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string state, string type, string description)
        {
            IQueryable<Park> query = _context.Parks.AsQueryable();

            // int limit = int.Parse(Request.Query["limit"]);

            int limit = 50;

            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }

            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }

            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }

            if (description != null)
            {
                query = query.Where(entry => entry.Description.Contains(description));
            }

            return await query.Take(limit).ToListAsync();
        }


        // GET: api/Parks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetPark(int id)
        {
            var park = await _context.Parks.FindAsync(id);

            if (park == null)
            {
                return NotFound();
            }

            return park;
        }

        // PUT: api/Parks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPark(int id, Park park)
        {
            if (id != park.ParkId)
            {
                return BadRequest();
            }

            _context.Entry(park).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkExists(id))
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

        // POST: api/Parks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Park>> PostPark(Park park)
        {
            _context.Parks.Add(park);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPark", new { id = park.ParkId }, park);
        }

        // DELETE: api/Parks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
            var park = await _context.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }

            _context.Parks.Remove(park);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParkExists(int id)
        {
            return _context.Parks.Any(e => e.ParkId == id);
        }
    }
}
