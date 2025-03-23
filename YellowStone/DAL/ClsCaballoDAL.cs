using ENT;

namespace DAL
{
    public class ClsCaballoDAL
    {

        public static List<ClsCaballo> listaClsCaballoCompletaDAL = new List<ClsCaballo>()
        {
            new ClsCaballo(1, "Blue Note", 0),
            new ClsCaballo(1, "Star", 0),
            new ClsCaballo(1, "Brandy ", 0),
            new ClsCaballo(1, "Lucky", 0),
            new ClsCaballo(1, "Apollo", 0),
            new ClsCaballo(1, "Scout", 0),
            new ClsCaballo(1, "Dakota", 0),
            new ClsCaballo(1, "Cash", 0),
            
        };

        public static List<ClsCaballo> ObtenerListaClsCaballoCompletaDAL()
        {
            return listaClsCaballoCompletaDAL;
        }
    }
}
