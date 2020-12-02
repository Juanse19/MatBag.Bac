using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IoT.DataAccess.EFCore;
using IoT.Entities.Models;

namespace IoT.WebApiCore.Controllers
{
    [Route("conveyors")]
    public class BhsConveyorsController : ControllerBase
    {
        private readonly IoTDataContext _context;

        public BhsConveyorsController(IoTDataContext context)
        {
            _context = context;
        }

        // GET: api/BhsConveyors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BhsConveyors>>> GetBhsConveyors()
        {
            return await _context.BhsConveyors.ToListAsync();
        }

        // GET: api/BhsConveyors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BhsConveyors>> GetBhsConveyors(int id)
        {
            var bhsConveyors = await _context.BhsConveyors.FindAsync(id);

            if (bhsConveyors == null)
            {
                return NotFound();
            }

            return bhsConveyors;
        }

        // PUT: api/BhsConveyors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBhsConveyors(int id, BhsConveyors bhsConveyors)
        {
            if (id != bhsConveyors.Id)
            {
                return BadRequest();
            }

            _context.Entry(bhsConveyors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BhsConveyorsExists(id))
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

        // POST: api/BhsConveyors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BhsConveyors>> PostBhsConveyors(BhsConveyors bhsConveyors)
        {
            _context.BhsConveyors.Add(bhsConveyors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBhsConveyors", new { id = bhsConveyors.Id }, bhsConveyors);
        }

        // DELETE: api/BhsConveyors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BhsConveyors>> DeleteBhsConveyors(int id)
        {
            var bhsConveyors = await _context.BhsConveyors.FindAsync(id);
            if (bhsConveyors == null)
            {
                return NotFound();
            }

            _context.BhsConveyors.Remove(bhsConveyors);
            await _context.SaveChangesAsync();

            return bhsConveyors;
        }

        private bool BhsConveyorsExists(int id)
        {
            return _context.BhsConveyors.Any(e => e.Id == id);
        }
    }
}
