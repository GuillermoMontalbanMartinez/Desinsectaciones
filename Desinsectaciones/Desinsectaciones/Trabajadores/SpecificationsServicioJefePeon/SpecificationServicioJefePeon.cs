using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.SpecificationsServicioJefePeon
{
    public class SpecificationServicioJefePeon : ISpecificationServicioJefePeon
    {
        public bool IsValid(IJefeEquipoPeon trabajador)
        {
            if (trabajador is not null)
            {
                return trabajador.IngresoPorServicio < 50 && trabajador.IngresoPorServicio > 0;
            }

            return false;
        }
    }
}
