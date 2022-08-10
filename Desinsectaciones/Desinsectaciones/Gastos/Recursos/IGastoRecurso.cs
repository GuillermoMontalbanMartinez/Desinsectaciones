using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Gastos.Recursos
{
    public interface IGastoRecurso
    {
        /// <summary>
        /// Coste de los distintos recursos utilizados en el servicio
        /// </summary>
        public double GastoRecurso { get; set; }
    }
}
