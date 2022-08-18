using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.SpecificationsServicioJefePeon
{
    public interface ISpecificationServicioJefePeon
    {
        public bool IsValid(IJefeEquipoPeon trabajador);
    }
}
