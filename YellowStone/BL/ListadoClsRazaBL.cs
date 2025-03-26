using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENT;

namespace BL
{
    public class ListadoClsRazaBL
    {

        /// <summary>
        /// Obtiene de la capa DAL un devolverá un listado completo de Razas con las reglas de negocio aplicadas
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns>ListaCompletaClsRazasBL</returns>
        public static List<ClsRaza> ObtenerListaCompletaClsRazasBL()
        {
            return ListadoClsRazaDAL.ObtenerListaCompletaClsRazaDAL();
        }
    }
}
