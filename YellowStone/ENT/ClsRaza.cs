using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsRaza
    {
        #region propiedades
        public int IdRaza { get; }
        public String NombreRaza { get; set; }
        #endregion

        #region Constructor

        public ClsRaza()
        {

        }
        public ClsRaza(int idRaza, String nombre)
        {
            this.IdRaza = idRaza;
            this.NombreRaza = nombre;
        }
        #endregion

    }
}
