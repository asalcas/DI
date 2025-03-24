using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Models
{
    public class ClsCaballoConRaza : ClsCaballo
    {
        #region Atributos
        private List<ClsRaza> listadoRazas;
        private ClsRaza razaSelected;

        #endregion

        #region Propiedades
        public List<ClsRaza> ListadoRazas
        {
            get { return listadoRazas; }
        }
        #endregion

        #region Constructores

        public ClsCaballoConRaza(ClsCaballo caballo, List<ClsRaza> listadoRazas)
        {
            this.Nombre = caballo.Nombre;
            //this.IdCaballo = caballo.IdCaballo;
            this.listadoRazas = listadoRazas;

        }

        #endregion
    }
}
