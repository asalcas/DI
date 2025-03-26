using System.Reflection.Metadata.Ecma335;
using DAL;
using ENT;

namespace BL
{
    public class ListadoClsCaballoBL
    {
        /// <summary>
        /// Obtiene de la capa DAL un devolverá un listado completo de Caballos con las reglas de negocio aplicadas
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns></returns>
        public static List<ClsCaballo> ObtenerListaClsCaballoCompletaBl()
        {
            return ListadoClsCaballoDAL.ObtenerListaClsCaballoCompletaDAL();
        }
    }
}
