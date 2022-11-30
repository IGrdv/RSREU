using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Data;
using PizzaDelivery.Models;

namespace PizzaDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private readonly DeliveryDbContext _context;

        public CheckController(DeliveryDbContext context)
        {
            _context = context;
        }

        // GET: api/Checks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Check>>> GetChecks()
        {
          if (_context.Checks == null)
          {
              return NotFound();
          }
            return await _context.Checks.ToListAsync();
        }

        // GET: api/Checks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Check>> GetCheck(int id)
        {
          if (_context.Checks == null)
          {
              return NotFound();
          }
            var check = await _context.Checks.FindAsync(id);

            if (check == null)
            {
                return NotFound();
            }

            return check;
        }

        // PUT: api/Checks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheck(int id, Check check)
        {
            if (id != check.Id)
            {
                return BadRequest();
            }

            _context.Entry(check).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckExists(id))
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

        // POST: api/Checks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Check>> PostCheck(Check check)
        {
          if (_context.Checks == null)
          {
              return Problem("Entity set 'DeliveryDbContext.Checks'  is null.");
          }
            _context.Checks.Add(check);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheck", new { id = check.Id }, check);
        }

        // DELETE: api/Checks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheck(int id)
        {
            if (_context.Checks == null)
            {
                return NotFound();
            }
            var check = await _context.Checks.FindAsync(id);
            if (check == null)
            {
                return NotFound();
            }

            _context.Checks.Remove(check);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CheckExists(int id)
        {
            return (_context.Checks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
