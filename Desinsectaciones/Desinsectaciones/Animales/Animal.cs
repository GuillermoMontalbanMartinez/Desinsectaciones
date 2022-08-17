using Desinsectaciones.Recursos.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Animales
{
    internal class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public Especie Especie { get; set; }
        public IVeneno Veneno { get; set; }

        public void VenenoUtilizado(IVeneno veneno)
        {
            this.Veneno = veneno;
        }
    }
}
