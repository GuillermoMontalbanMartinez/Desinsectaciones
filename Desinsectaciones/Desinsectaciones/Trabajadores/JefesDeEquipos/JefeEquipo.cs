using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.JefesDeEquipos
{
    public class JefeEquipo : IJefeDeEquipo
    {
        public double IngresoPorServicio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
    }
}
