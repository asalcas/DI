using ENT;

namespace DAL
{
    public class ListadoClsCaballoDAL
    {

        public static List<ClsCaballo> listaClsCaballoCompletaDAL = new List<ClsCaballo>()
        {
            new ClsCaballo(11, "Blue Note", 0),
            new ClsCaballo(12, "Star", 0),
            new ClsCaballo(13, "Brandy ", 0),
            new ClsCaballo(14, "Lucky", 0),
            new ClsCaballo(15, "Apollo", 0),
            new ClsCaballo(16, "Scout", 0),
            new ClsCaballo(17, "Dakota", 0),
            new ClsCaballo(18, "Cash", 0),
            
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

        /// <summary>
        /// Función que va a buscar un objeto tipo "ClsCaballo" en la Base de datos dependiendo de su ID
        /// Pre: No puede ser un 'id' Null NUNCA
        /// Post: Siempre devolverá un ClsCaballo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsCaballo ObtenerCaballoPorID(int id)
        {
            return listaClsCaballoCompletaDAL.Find(caballo => caballo.IdCaballo == id);

        }
    }
}
