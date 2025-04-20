using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class ClsConexionDB
    {
        /// <summary>
        /// Abre la conexion a la BD
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static SqlConnection abrirConexion()
        {
            SqlConnection miConexion = new SqlConnection();
            try
            {
                miConexion.ConnectionString=
                                        "server=alvaro-salvador.database.windows.net;database=alvaroDB;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;";

                miConexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo abrir la conexion", ex);
            }

            return miConexion;
        }

        /// <summary>
        /// Cierra la conexion a la BD
        /// </summary>
        /// <param name="miConexion"></param>
        public static void cerrarConexion(ref SqlConnection miConexion)
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
        }
    }
}
