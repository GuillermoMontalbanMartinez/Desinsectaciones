﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Recursos.Venenos
{
    public interface IVeneno : IRecurso
    {
        public string UnidadMedida { get; set; }
    }
}
