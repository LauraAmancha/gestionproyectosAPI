using System;
using System.Collections.Generic;

namespace GestionProyectosAPI.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public ICollection<ProyectoEmpleado> ProyectoEmpleados { get; set; } = new List<ProyectoEmpleado>();
    }
}