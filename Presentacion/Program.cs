using Entidades;
using System;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Id = 1;
            cliente.Nombres = "*** ADRUIN QUINTERO ***";
            cliente.Apellidos = "QUINTERO HERNANDEZ";
            cliente.Documento = "89897867547";
            cliente.Direccion = "CALLE 56 NO. 45-34";
            cliente.TipoCliente = "ESTANDAR";

            Proveedor proveedor = new Proveedor();

            proveedor.Id = 1;
            proveedor.Nombres = "LUIS DAVID";
            proveedor.Apellidos = "ARAGÓN ROSADO";
            proveedor.Documento = "1243621657";
            proveedor.Direccion = "CALLE 43 NO. 45-34";
            proveedor.NIT = "1F33GV-1";
            proveedor.RazonSocial = "FAMILCOL S.A";
            proveedor.Correo = "FAMILCOL@EMPRESA.COM";

            System.Console.WriteLine(cliente.ToString());
            System.Console.WriteLine(proveedor.ToString());
            Console.ReadKey();
            
        }
    }
}
