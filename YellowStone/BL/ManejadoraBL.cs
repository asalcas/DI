using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraBL
    {
        /// <summary>
        /// Esta función llama a la capa DAL para actualizar la raza de un caballo aplicando las reglas de negocio
        /// Pre: None
        /// Post: Devolverá o 0 o 1 
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static int actualizarRazaCaballoBL(int idCaballo, int idRaza)
        {



            return ManejadoraDAL.actualizarListaCaballos(idCaballo, idRaza);
        }
    }
}
