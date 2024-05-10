using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APITechCoffee.Data;
using APITechCoffee.Models;

namespace APITechCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemProjetoServicoController : ControllerBase
    {
        private readonly APITechCoffeeContext _context;

        public ItemProjetoServicoController(APITechCoffeeContext context)
        {
            _context = context;
        }

        // GET: api/ItemProjetoServicoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemProjetoServico>>> GetItemProjetoServico()
        {
          if (_context.ItemProjetoServico == null)
          {
              return NotFound();
          }
            return await _context.ItemProjetoServico.ToListAsync();
        }

        // GET: api/ItemProjetoServicoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemProjetoServico>> GetItemProjetoServico(int id)
        {
          if (_context.ItemProjetoServico == null)
          {
              return NotFound();
          }
            var itemProjetoServico = await _context.ItemProjetoServico.FindAsync(id);

            if (itemProjetoServico == null)
            {
                return NotFound();
            }

            return itemProjetoServico;
        }

        // PUT: api/ItemProjetoServicoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemProjetoServico(int id, ItemProjetoServico itemProjetoServico)
        {
            if (id != itemProjetoServico.id)
            {
                return BadRequest();
            }

            _context.Entry(itemProjetoServico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemProjetoServicoExists(id))
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

        // POST: api/ItemProjetoServicoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemProjetoServico>> PostItemProjetoServico(ItemProjetoServico itemProjetoServico)
        {
          if (_context.ItemProjetoServico == null)
          {
              return Problem("Entity set 'APITechCoffeeContext.ItemProjetoServico'  is null.");
          }
            _context.ItemProjetoServico.Add(itemProjetoServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemProjetoServico", new { id = itemProjetoServico.id }, itemProjetoServico);
        }

        // DELETE: api/ItemProjetoServicoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemProjetoServico(int id)
        {
            if (_context.ItemProjetoServico == null)
            {
                return NotFound();
            }
            var itemProjetoServico = await _context.ItemProjetoServico.FindAsync(id);
            if (itemProjetoServico == null)
            {
                return NotFound();
            }

            _context.ItemProjetoServico.Remove(itemProjetoServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemProjetoServicoExists(int id)
        {
            return (_context.ItemProjetoServico?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
