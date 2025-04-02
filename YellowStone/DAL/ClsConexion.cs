using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class ClsConexion
    {

        public static SqlConnection abrirConexion()
        {
            SqlConnection miConexion = new();

            try
            {

                miConexion.ConnectionString =
                    "server=alvaro-salvador.database.windows.net;database=alvaroDB;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;";

                miConexion.Open();

            }
            catch (SqlException e)
            {
                throw e;
            }


            return miConexion;
        }

        public static void cerrarConexion(ref SqlConnection miConexion)
        {
            miConexion.Close();
        }
    }
}
