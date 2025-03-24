using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
namespace DAL
{
    public class ManejadoraDAL
    {
        /// <summary>
        /// Esta función actualzia la raza de un caballo del listado
        /// Pre: Los idCaballo e idRaza deben existir en el listado
        /// Post: Nos devolvera un 0 o un 1
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static int actualizarListaCaballos(int idCaballo, int idRaza)
        {
            int afectado = 0;
            int indice = 0;

            while(afectado != 1 && indice < ListadoClsCaballoDAL.listaClsCaballoCompletaDAL.Count())
            {
                
            }

           

            return afectado;
        }

    }
}
