using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos
{
    public interface IRecurso : IComun
    {
        public double Coste { get; set; }
    }
}
