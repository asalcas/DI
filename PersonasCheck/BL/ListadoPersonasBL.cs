using ENT;
using DAL;

namespace BL
{
    public class ListadoPersonasBL
    {
        /// <summary>
        /// Función que llamará a la capa DAL y traerá de la Base de Datos una lista Completa de Registros de Persona
        /// Pre: None
        /// Post: La lista será COMPLETA, con todos los registros de la BD
        /// </summary>
        /// <returns> List<ClsPersona> </returns>
        public static List<ClsPersona> obtenerListadoCompletoBL()
        {
            return DAL.ListadoClsPersonasDAL.listadoCompletoPersonasDAL();
        }
    }
}
