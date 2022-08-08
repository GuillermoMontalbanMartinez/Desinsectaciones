using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores
{
    public interface ITrabajador : IComunTrabajadorCliente
    {
        public new string Telefono { get; set; }
        public new string Email { get; set; }
        public double IngresoPorServicio { get; set; }
        
    }
}
