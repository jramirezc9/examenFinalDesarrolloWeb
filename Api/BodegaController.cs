using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenFinal.Data;
using ExamenFinal.Models;

namespace ExamenFinal.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodegaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BodegaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Bodega
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bodega>>> GetBodega()
        {
            return await _context.Bodega.ToListAsync();
        }

        // GET: api/Bodega/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bodega>> GetBodega(int id)
        {
            var bodega = await _context.Bodega.FindAsync(id);

            if (bodega == null)
            {
                return NotFound();
            }

            return bodega;
        }

        // PUT: api/Bodega/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBodega(int id, Bodega bodega)
        {
            if (id != bodega.CodigoIngreso)
            {
                return BadRequest();
            }

            _context.Entry(bodega).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodegaExists(id))
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

        // PUT: api/Bodega/salida/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("salida/{id}")]
        public async Task<IActionResult> PutBodegaSalida(int id, Salida salida)
        {

            var bodega = await _context.Bodega.FindAsync(id);
            if (bodega == null)
            {
                return NotFound();
            }

            bodega.ExistenciaMinima = bodega.ExistenciaMinima - salida.Cantidad;
            bodega.FechaSalida = salida.FechaSalida;
            _context.Entry(bodega).State = EntityState.Modified;
            //_context.Bodega.Remove(bodega);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // POST: api/Bodega
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bodega>> PostBodega(Bodega bodega)
        {
            _context.Bodega.Add(bodega);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBodega", new { id = bodega.CodigoIngreso }, bodega);
        }

        // DELETE: api/Bodega/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodega(int id)
        {
            var bodega = await _context.Bodega.FindAsync(id);
            if (bodega == null)
            {
                return NotFound();
            }

            bodega.Status = false;
            _context.Entry(bodega).State = EntityState.Modified;
            //_context.Bodega.Remove(bodega);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BodegaExists(int id)
        {
            return _context.Bodega.Any(e => e.CodigoIngreso == id);
        }
    }
}
