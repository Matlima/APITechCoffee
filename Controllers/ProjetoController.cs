using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APITechCoffee.Data;
using APITechCoffee.Models.Jobs;

namespace APITechCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly APITechCoffeeContext _context;

        public ProjetoController(APITechCoffeeContext context)
        {
            _context = context;
        }

        // GET: api/Projeto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projeto>>> GetProjeto()
        {
          if (_context.Projeto == null)
          {
              return NotFound();
          }
            return await _context.Projeto.ToListAsync();
        }

        // GET: api/Projeto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Projeto>> GetProjeto(int id)
        {
          if (_context.Projeto == null)
          {
              return NotFound();
          }
            var projeto = await _context.Projeto.FindAsync(id);

            if (projeto == null)
            {
                return NotFound();
            }

            return projeto;
        }

        // PUT: api/Projeto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjeto(int id, Projeto projeto)
        {
            if (id != projeto.id)
            {
                return BadRequest();
            }

            _context.Entry(projeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjetoExists(id))
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

        // POST: api/Projeto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Projeto>> PostProjeto(Projeto projeto)
        {
          if (_context.Projeto == null)
          {
              return Problem("Entity set 'APITechCoffeeContext.Projeto'  is null.");
          }
            _context.Projeto.Add(projeto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjeto", new { id = projeto.id }, projeto);
        }

        // DELETE: api/Projeto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjeto(int id)
        {
            if (_context.Projeto == null)
            {
                return NotFound();
            }
            var projeto = await _context.Projeto.FindAsync(id);
            if (projeto == null)
            {
                return NotFound();
            }

            _context.Projeto.Remove(projeto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjetoExists(int id)
        {
            return (_context.Projeto?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
