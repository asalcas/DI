using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsCaballo
    {
        #region Atributos

        private int idCaballo;

        #endregion

        #region Propiedades
        
         public int IdCaballo
        {
            get
            {
                return idCaballo;
            }

        }
        // EL Equivalente para java seria: 

        //public int getIdCaballo()
        //{
        //    return idCaballo;
        //}

        

        // PROPIEDAD AUTOIMPLEMENTADA

        public string Nombre { get; set; } // El unico inconveniente de esto, es que no podemos meter codigo dentro
        public int IdRaza { get; set; }
        #endregion

        #region Constructores
        public ClsCaballo()
        {
            // Esto es necesario si en nuestra aplicación queremos por ejemplo editar un Objeto tipo caballo.
        }

        public ClsCaballo(int idCaballo, string Nombre, int IdRaza)
        {
            this.idCaballo = idCaballo;
            this.Nombre = Nombre;
            this.IdRaza = IdRaza;
        }

        #endregion
    }
}
