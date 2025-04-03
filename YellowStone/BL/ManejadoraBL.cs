using DAL;
using ENT;
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


            return ManejadoraDAL.actualizarListaCaballosListado(idCaballo, idRaza);
        }

        /// <summary>
        /// Esta función llama a la capa DAL para actualizar la raza de un caballo aplicando las reglas de negocio, esta función devuelve una tupla.
        /// Tipos de la tupla: 
        /// - List<ClsCaballo>
        /// - int (numero de actualizaciones)
        /// </summary>
        /// <param name="idCaballo"></param>
        /// <param name="idRaza"></param>
        /// <returns></returns>
        public static (int, List<ClsCaballo>) actualizarListaRazaCaballoBL (int idCaballo, int idRaza)
        {
            var resultado = ListadoClsCaballoDAL.editarUnCaballo(idCaballo, idRaza);
            return (resultado.Item1, resultado.Item2);
        }   
             
    }
}
