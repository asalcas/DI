using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENT;

namespace BL
{
    public class ClsRazaBL
    {
        public static List<ClsRaza> ListaCompletaClsRazasBL = ClsRazaDAL.ObtenerListaCompletaClsRazaDAL();

        public List<ClsRaza> obtenerListaCompletaClsRazasBL()
        {
            return ListaCompletaClsRazasBL;
        }
    }
}
