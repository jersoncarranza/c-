using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad2;
using System.Data;
using System.Data.OracleClient;


namespace conexion
{
    public class Ejecutar
    {
        public static Boolean Guardar(Cliente cli)
        {
            OracleCommand com = Metodo.CrearProcedimiento("insertarCliente");
            com.Parameters.Add("codigo", OracleType.VarChar).Value = "2";
            com.Parameters.Add("nombre", OracleType.VarChar).Value = cli.nombre;
            com.Parameters.Add("edad", OracleType.VarChar).Value = cli.edad;
            Console.WriteLine(cli);
            return Metodo.EjecutarProcedimiento(com);
        }
    }
}
