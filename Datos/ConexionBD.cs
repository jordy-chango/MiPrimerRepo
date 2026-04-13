using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Datos
{
    public class ConexionBD
    {
        private static string cadena =
            "Server=NERO\\SQLEXPRESS;Database=FeriaEmprendimientosDB;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
