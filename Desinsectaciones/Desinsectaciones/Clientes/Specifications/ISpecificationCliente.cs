using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Clientes.Specifications
{
    public interface ISpecificationCliente
    {
        public bool IsValid(ICliente cliente);
    }
}
