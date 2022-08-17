using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Gastos.Equipos
{
    public interface IGastoEquipo
    {
        /// <summary>
        /// Ingreso sumado del jefe de equipo + ingreso de los peones
        /// </summary>
        public double GastoEquipo { get; set; }
    }
}
