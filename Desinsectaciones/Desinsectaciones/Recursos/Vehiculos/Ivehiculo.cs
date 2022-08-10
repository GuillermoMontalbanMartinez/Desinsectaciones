using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos.Vehiculos
{
    public interface IVehiculo : IComun
    {
        public string Marca { get; set; }
        public string Carroceria { get; set; }
    }
}
