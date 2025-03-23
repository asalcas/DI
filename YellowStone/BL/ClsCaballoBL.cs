using System.Reflection.Metadata.Ecma335;
using DAL;
using ENT;

namespace BL
{
    public class ClsCaballoBL
    {
        public static List<ClsCaballo> listaClsCaballoCompletaBL = ClsCaballoDAL.ObtenerListaClsCaballoCompletaDAL();

        public List<ClsCaballo> ObtenerListaClsCaballoCompletaBl()
        {
            return listaClsCaballoCompletaBL;
        }
    }
}
