using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.JefesDeEquipos.SpecificationsJefe
{
    public interface ISpecificationJefe
    {
        public bool IsValid(IJefeDeEquipo jefe);
    }
}
