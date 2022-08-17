using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos.Venenos
{
    public interface IVeneno : IRecurso
    {
        public UnidadMedida UnidadMedida { get; set; }
        public double Cantidad { get; set; }
    }
}
