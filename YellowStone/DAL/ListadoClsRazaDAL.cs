using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class ListadoClsRazaDAL
    {



        public static List<ClsRaza> listaCompletaClsRazaDAL()
        {
            /*new ClsRaza(1, "Mustang"),
            new ClsRaza(2, "Paint Horse"),
            new ClsRaza(3, "Rocky Mountain"),
            new ClsRaza(4, "Appaloosa"),
            new ClsRaza(5, "Pinto"),
            new ClsRaza(6, "Cortador")*/

            List<ClsRaza> listadoRazas = new();
            SqlConnection conexion;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                conexion = ClsConexion.abrirConexion();
                miComando.CommandText = "SELECT * FROM ClsRazas";
                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        ClsRaza raza = new ClsRaza((int)miLector["IdRaza"]);
                        raza.NombreRaza = (String)miLector["NombreRaza"];
                        listadoRazas.Add(raza);
                    }

                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return listadoRazas;
        }

        /// <summary>
        /// Esta funcion estática devolvera el atributo privado 'listaCompletaClsRazaDAL' 
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns>listaCompletaClsRazaDAL</returns>
        public static List<ClsRaza> ObtenerListaCompletaClsRazaDAL()
        {
            return listaCompletaClsRazaDAL();
        }


    }
}
