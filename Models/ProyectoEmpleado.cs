namespace GestionProyectosAPI.Models
{
    public class ProyectoEmpleado
    {
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; } = null!;

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; } = null!;
    }
}