using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace conexion
{
    public class Metodo
    {
        public static OracleCommand CrearProcedimiento(string proc)
        {
            OracleConnection con = new OracleConnection(conectar.conexionString);
            OracleCommand comm = new OracleCommand(proc, con);

            comm.CommandType = CommandType.StoredProcedure;
            return comm;
        }

        public static Boolean EjecutarProcedimiento(OracleCommand com)
        {
            com.Connection.Open();
            if(com.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            com.Connection.Dispose();
            com.Connection.Close();
        }
    }
}
