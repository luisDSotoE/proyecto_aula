﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor : Persona
    {
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{NIT};{RazonSocial};{Correo};{Telefono}";
        }
    }
}
