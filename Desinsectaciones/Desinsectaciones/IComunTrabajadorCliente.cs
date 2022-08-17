using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public interface IComunTrabajadorCliente : IComun
    {
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
