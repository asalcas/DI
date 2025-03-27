using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace DAL
{
    public class ListadoClsRazaDAL
    {

        public static List<ClsRaza> listaCompletaClsRazaDAL = new List<ClsRaza>()
        {
            new ClsRaza(1, "Mustang"),
            new ClsRaza(2, "Paint Horse"),
            new ClsRaza(3, "Rocky Mountain"),
            new ClsRaza(4, "Appaloosa"),
            new ClsRaza(5, "Pinto"),
            new ClsRaza(6, "Cortador")
        };

        /// <summary>
        /// Esta funcion estática devolvera el atributo privado 'listaCompletaClsRazaDAL' 
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns>listaCompletaClsRazaDAL</returns>
        public static List<ClsRaza> ObtenerListaCompletaClsRazaDAL()
        {
            return listaCompletaClsRazaDAL;
        }


    }
}
