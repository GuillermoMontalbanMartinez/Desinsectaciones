using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Gastos.Empresas
{
    public interface IGastoEmpresa
    {
        /// <summary>
        /// Sueldo de todo el equipo + Sueldo gerente + Gasto Veneno
        /// </summary>
        public double GastoEmpresa { get; set; }
    }
}
