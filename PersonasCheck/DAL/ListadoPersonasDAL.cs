using ENT;
using Microsoft.Data.SqlClient;

namespace DAL

{
    public class ListadoClsPersonasDAL
    {
        /// <summary>
        ///  Función que accede a la Base de datos y saca una Lista de Personas con los valores de los tipos 'ClsPersona'
        ///  PRE: None
        ///  POST: El listado obtenido será COMPLETO, con todos los registros de la BD
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<ClsPersona> listadoCompletoPersonasDAL()
        {
            List<ClsPersona> personasBD = new List<ClsPersona>();
            try
            {
                using (SqlConnection miConexion = ClsConexionDB.abrirConexion())
                {
                    using (SqlCommand miComando = new SqlCommand())
                    {
                        miComando.CommandText = @"SELECT ID, Nombre, Apellidos, FechaNacimiento 
                                          FROM Personas;";
                        miComando.Connection = miConexion;

                        using (SqlDataReader miLector = miComando.ExecuteReader())
                        {
                            if (miLector.HasRows)
                            {
                                while (miLector.Read())
                                {
                                    ClsPersona personitaNueva = new ClsPersona((int)miLector["ID"]);

                                    if (miLector["Nombre"] != DBNull.Value)
                                    {
                                        personitaNueva.Nombre = (String)miLector["Nombre"];
                                    }
                                    if (miLector["Apellidos"] != DBNull.Value)
                                    {
                                        personitaNueva.Apellido = (String)miLector["Apellidos"];
                                    }
                                    if (miLector["FechaNacimiento"] != DBNull.Value)
                                    {
                                        personitaNueva.FechaNacimiento = (DateTime)miLector["FechaNacimiento"];
                                    }
                                    personasBD.Add(personitaNueva);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al acceder a la base de datos", ex);
            }

            return personasBD;
        }
    }
}
