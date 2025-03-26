using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Models
{
    public class ClsCaballoConRazas : ClsCaballo
    {
        #region Atributos
        public List<ClsRaza> ListadoRazas { get; }
        public ClsRaza RazaSelected { get; set; }

        #endregion
        /*
        #region Propiedades
        public List<ClsRaza> ListadoRazas
        {
            get { return listadoRazas; }
        }
        #endregion
        */
        #region Constructores

        public ClsCaballoConRazas(ClsCaballo caballo, List<ClsRaza> listadoRazas, ClsRaza razaSeleccionada = null) 
            : base(caballo.IdCaballo, caballo.Nombre, caballo.IdRaza)
        {
            
            this.ListadoRazas = listadoRazas;
            this.RazaSelected = razaSeleccionada;
        }

        #endregion
    }
}
