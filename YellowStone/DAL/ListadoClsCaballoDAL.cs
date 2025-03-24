using ENT;

namespace DAL
{
    public class ListadoClsCaballoDAL
    {

        public static List<ClsCaballo> listaClsCaballoCompletaDAL = new List<ClsCaballo>()
        {
            new ClsCaballo(1, "Blue Note", 0),
            new ClsCaballo(2, "Star", 0),
            new ClsCaballo(3, "Brandy ", 0),
            new ClsCaballo(4, "Lucky", 0),
            new ClsCaballo(5, "Apollo", 0),
            new ClsCaballo(6, "Scout", 0),
            new ClsCaballo(7, "Dakota", 0),
            new ClsCaballo(8, "Cash", 0),
            
        };

        /// <summary>
        /// Función estática que devuelve el atributo privado de "ClsCaballoDAL"
        /// Pre: None
        /// Post: None
        /// </summary>
        /// <returns>listaClsCaballoCompletaDAL</returns>
        public static List<ClsCaballo> ObtenerListaClsCaballoCompletaDAL()
        {
            return listaClsCaballoCompletaDAL;
        }
    }
}
