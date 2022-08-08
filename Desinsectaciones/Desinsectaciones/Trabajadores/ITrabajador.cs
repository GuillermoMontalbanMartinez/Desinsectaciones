using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores
{
    public interface ITrabajador : IComunTrabajadorCliente
    {
        public double IngresoPorServicio { get; set; }
        public double Sueldo { get; set; }
        
    }
}
