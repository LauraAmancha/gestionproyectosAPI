// EmpleadosController.cs
[HttpPost]
[Route("api/empleados")]
public IActionResult CrearEmpleado([FromBody] Empleado empleado)
{
    if (empleado == null) return BadRequest();
    _context.Empleados.Add(empleado);
    _context.SaveChanges();
    return Ok(empleado);
}

// ProyectosController.cs
[HttpPost]
[Route("api/proyectos")]
public IActionResult CrearProyecto([FromBody] Proyecto proyecto)
{
    if (proyecto == null) return BadRequest();
    _context.Proyectos.Add(proyecto);
    _context.SaveChanges();
    return Ok(proyecto);
}