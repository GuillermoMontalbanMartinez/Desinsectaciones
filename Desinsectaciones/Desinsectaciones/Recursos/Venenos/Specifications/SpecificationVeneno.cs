using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos.Venenos.Specifications
{
    public class SpecificationVeneno : ISpecificationVeneno
    {
        public bool IsValid(IVeneno veneno)
        {
            if (veneno is not null)
            {
                return veneno.Coste < 2 && veneno.Coste > 0;
            }
            return false;
        }
    }
}
