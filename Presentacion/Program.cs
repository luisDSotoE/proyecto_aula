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
            cliente.Nombres = "LUIS CAMILO";
            cliente.Apellidos = "ARAGÓN ROSADO";
            cliente.Documento = "1243621657";
            cliente.Direccion = "CALLE 43 NO. 45-34";
            cliente.TipoCliente = "ESTANDAR";

            Proveedor proveedor = new Proveedor();

            proveedor.Id = 1;
            proveedor.Nombres = "LUIS CAMILO";
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
