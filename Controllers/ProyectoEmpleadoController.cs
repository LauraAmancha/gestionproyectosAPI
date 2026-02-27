using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionProyectosAPI.Data;
using GestionProyectosAPI.Models;

namespace GestionProyectosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoEmpleadoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProyectoEmpleadoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoEmpleado>>> GetAsignaciones()
        {
            return await _context.ProyectoEmpleados
                .Include(pe => pe.Proyecto)
                .Include(pe => pe.Empleado)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ProyectoEmpleado>> PostAsignacion(ProyectoEmpleado asignacion)
        {
            _context.ProyectoEmpleados.Add(asignacion);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsignaciones), null, asignacion);
        }

        [HttpDelete("{proyectoId}/{empleadoId}")]
        public async Task<IActionResult> DeleteAsignacion(int proyectoId, int empleadoId)
        {
            var asignacion = await _context.ProyectoEmpleados.FindAsync(proyectoId, empleadoId);
            if (asignacion == null) return NotFound();

            _context.ProyectoEmpleados.Remove(asignacion);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}