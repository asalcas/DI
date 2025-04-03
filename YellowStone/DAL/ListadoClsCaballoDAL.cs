using ENT;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ListadoClsCaballoDAL
    {

        /// <summary>
        /// Función que va a realizar una consulta SQL a la Base de datos donde sacaremos una lista completa de Caballos
        /// </summary>
        /// <returns></returns>
        public static List<ClsCaballo> listaClsCaballoCompletaDAL()
        {
            /*new ClsCaballo(11, "Blue Note", 0),
            new ClsCaballo(12, "Star", 0),
            new ClsCaballo(13, "Brandy ", 0),
            new ClsCaballo(14, "Lucky", 0),
            new ClsCaballo(15, "Apollo", 0),
            new ClsCaballo(16, "Scout", 0),
            new ClsCaballo(17, "Dakota", 0),
            new ClsCaballo(18, "Cash", 0),
            */

            List<ClsCaballo> listadoCaballos = new();
            SqlConnection miConexion;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                miConexion = ClsConexion.abrirConexion();
                miComando.CommandText = "SELECT * FROM ClsCaballos";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        ClsCaballo caballoNuevo = new ClsCaballo((int)miLector["IdCaballo"]);
                        if (miLector["NombreCaballo"] != DBNull.Value)
                        {
                            caballoNuevo.Nombre = (String)miLector["NombreCaballo"];

                        }
                        if (miLector["IdRaza"] != DBNull.Value)
                        {
                            caballoNuevo.IdRaza = (int)miLector["IdRaza"];

                        }
                        listadoCaballos.Add(caballoNuevo);
                    }
                }
                miLector.Close();
                ClsConexion.cerrarConexion(ref miConexion);
                
            }
            catch (SqlException e)
            {
                throw e;
            }

            return listadoCaballos;
        }


        public static List<ClsCaballo> editarUnCaballo(int idCaballo, int idRaza)
        {
            List<ClsCaballo> listadoCaballo = new List<ClsCaballo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@IdCaballo", SqlDbType.Int).Value = idCaballo;
            miComando.Parameters.Add("@IdRaza", SqlDbType.Int).Value = idRaza;


            SqlDataReader miLector;

            try
            {
                conexion = ClsConexion.abrirConexion();
                miComando.CommandText = "UPDATE ClsCaballos SET IdRaza = @IdRaza WHERE IdCaballo = @IdCaballo;";
                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
             

                    }
                }


            }
            catch (SqlException e)
            {
                throw e;
            }


        }

        /// <summary>
        /// Función estática que devuelve el atributo privado de "ClsCaballoDAL"
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns>listaClsCaballoCompletaDAL</returns>
        public static List<ClsCaballo> ObtenerListaClsCaballoCompletaDAL()
        {
            return listaClsCaballoCompletaDAL();
        }

        /// <summary>
        /// Función que va a buscar un objeto tipo "ClsCaballo" en la Base de datos dependiendo de su ID
        /// Pre: No puede ser un 'id' Null NUNCA
        /// Post: Siempre devolverá un ClsCaballo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsCaballo ObtenerCaballoPorID(int id)
        {
            List<ClsCaballo> listaCaballosBusqueda = listaClsCaballoCompletaDAL();

            return listaCaballosBusqueda.Find(caballo => caballo.IdCaballo == id);

        }
    }
}
