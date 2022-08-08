using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Animales
{
    public interface IAnimal : IComun
    {
        public Especie Especie { get; set; }
    }
}
