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
        /// Esta función actualiza la raza de un caballo del listado
        /// Pre: Los idCaballo e idRaza deben existir en el listado
        /// Post: Nos devolvera un 0 o un 1
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static int actualizarListaCaballos(int idCaballo, int idRaza)
        {
            bool encontrado = false;
            int numFilasAfectadas = 0;
            int indice = 0;
            List<ClsCaballo> listadoCaballosCompletoDal = ListadoClsCaballoDAL.listaClsCaballoCompletaDAL();

            while(!encontrado && indice < listadoCaballosCompletoDal.Count())
            {
                if (listadoCaballosCompletoDal[indice].IdCaballo == idCaballo)
                {
                    listadoCaballosCompletoDal[indice].IdRaza = idRaza;

                    numFilasAfectadas++;
                    encontrado = true;
                }
                indice++;
            }

            return numFilasAfectadas;
        }

    }
}
