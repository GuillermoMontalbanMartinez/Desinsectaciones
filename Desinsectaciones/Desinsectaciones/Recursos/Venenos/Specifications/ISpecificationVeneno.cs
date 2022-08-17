using Desinsectaciones.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos.Venenos.Specifications
{
    public interface ISpecificationVeneno
    {
        public bool IsValid(IVeneno veneno);
    }
}
