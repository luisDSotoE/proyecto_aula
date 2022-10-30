﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IServicioRoles
    {
        bool Agregar(Persona persona);
        List<Producto> Listar();
        bool Actualizar(Persona persona, int posicionPersona);
        bool Eliminar(Persona persona, string IdPersona);
    }
}
