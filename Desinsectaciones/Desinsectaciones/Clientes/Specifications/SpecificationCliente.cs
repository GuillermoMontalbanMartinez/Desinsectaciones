using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Clientes.Specifications
{
    public class SpecificationCliente : ISpecificationCliente
    {
        public bool IsValid(ICliente cliente)
        {
            if (cliente is null) return false;
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Email) ||
                string.IsNullOrEmpty(cliente.Telefono) || (cliente.CodigoPostal <= 0 || cliente.CodigoPostal > 9999))
            {
                return false;
            }

            return true;
        }
    }
}
