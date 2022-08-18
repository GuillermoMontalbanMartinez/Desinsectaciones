using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.JefesDeEquipos.SpecificationsJefe
{
    public class SpecificationJefe : ISpecificationJefe
    {
        public bool IsValid(IJefeDeEquipo jefe)
        {
            if (jefe is not null)
            {
                return jefe.Peones.Count == 3;
            }

            return false;
        }
    }
}
