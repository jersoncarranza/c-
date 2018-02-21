using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
    public class conectar
    {

        private static String cConexion = "data source=localhost; user id=prueba; password=111111; unicode=true";

        public static String conexionString
        {
            get { return conectar.cConexion; }
        }
    }
}
