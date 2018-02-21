using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad2;
using conexion;

namespace Controlador
{
    public class Cliente
    {
        public static Boolean Guardar(Entidad2.Cliente cli)
        {
            
            return  Ejecutar.Guardar(cli);
        }
    }
}
