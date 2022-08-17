using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desinsectaciones.Recursos.Venenos;

namespace Desinsectaciones.Animales
{
    public interface IAnimal : IComun
    {
        public Especie Especie { get; set; }
        public IVeneno Veneno { get; set; }
        public void VenenoUtilizado(IVeneno veneno);
    }
}
