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
        #region Constructores

        /// <summary>
        /// Constructor de objeto 'ClsCaballoConRazas' al que le pasamos un objeto caballo y una lista de razas para crearlo.
        /// </summary>
        /// <param name="caballo"></param>
        /// <param name="listadoRazas"></param>
        public ClsCaballoConRazas(ClsCaballo caballo, List<ClsRaza> listadoRazas)// ClsRaza razaSeleccionada = null) 
            : base(caballo.IdCaballo, caballo.Nombre, caballo.IdRaza)
        {

            this.ListadoRazas = listadoRazas;

            if (caballo.IdRaza == 0)
            {
                this.RazaSelected = listadoRazas[0];// para mostrar Selecciona una raza, antes estaba vacío no se que prefiere

            }
            else
            {
                this.RazaSelected = listadoRazas.Find(r => r.IdRaza == caballo.IdRaza);
            }

            #endregion
        }
    }
}
