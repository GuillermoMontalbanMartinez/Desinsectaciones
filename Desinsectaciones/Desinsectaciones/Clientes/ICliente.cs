using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Clientes
{
    public interface ICliente : IComun
    {
        public int CodigoPostal { get; set; }
        
    }
}
