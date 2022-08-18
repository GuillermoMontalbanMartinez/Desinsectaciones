using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desinsectaciones.Trabajadores.Peones;

namespace Desinsectaciones.Trabajadores.JefesDeEquipos
{
    public interface IJefeDeEquipo : IJefeEquipoPeon
    {
        public List<Peon> Peones { get; }
    }
}
