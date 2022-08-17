using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.Gerentes
{
    public interface IGerente : ITrabajador
    {
        public double SueldoFijo { get; set; }
    }
}
