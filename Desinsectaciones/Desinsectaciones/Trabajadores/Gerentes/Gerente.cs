﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones.Trabajadores.Gerentes
{
    public class Gerente : IGerente
    {
        public double SueldoFijo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
    }
}
