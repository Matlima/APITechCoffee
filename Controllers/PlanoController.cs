using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APITechCoffee.Data;
using APITechCoffee.Models.CRM;

namespace APITechCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        private readonly APITechCoffeeContext _context;

        public PlanoController(APITechCoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Plano
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plano>>> GetPlano()
        {
          if (_context.Plano == null)
          {
              return NotFound();
          }
            return await _context.Plano.ToListAsync();
        }

        // GET: api/Plano/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plano>> GetPlano(int id)
        {
          if (_context.Plano == null)
          {
              return NotFound();
          }
            var plano = await _context.Plano.FindAsync(id);

            if (plano == null)
            {
                return NotFound();
            }

            return plano;
        }

        // PUT: api/Plano/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlano(int id, Plano plano)
        {
            if (id != plano.id)
            {
                return BadRequest();
            }

            _context.Entry(plano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanoExists(id))
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

        // POST: api/Plano
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Plano>> PostPlano(Plano plano)
        {
          if (_context.Plano == null)
          {
              return Problem("Entity set 'APITechCoffeeContext.Plano'  is null.");
          }
            _context.Plano.Add(plano);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlano", new { id = plano.id }, plano);
        }

        // DELETE: api/Plano/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlano(int id)
        {
            if (_context.Plano == null)
            {
                return NotFound();
            }
            var plano = await _context.Plano.FindAsync(id);
            if (plano == null)
            {
                return NotFound();
            }

            _context.Plano.Remove(plano);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanoExists(int id)
        {
            return (_context.Plano?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
