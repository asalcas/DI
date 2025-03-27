using BL;
using ENT;
using MAUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.ViewModels
{
    public class ListaClsCaballoConRazas
    {
        public ObservableCollection<ClsCaballoConRazas> listadoCaballosConListaRazas { get; }
        


        /// <summary>
        /// Constructor de ListaClsCaballoConRazas rellenando un ObservableCollection con objetos ClsCaballoConRazas
        /// </summary>
        public ListaClsCaballoConRazas()
        {
            List<ClsCaballo> listadoCaballos = ListadoClsCaballoBL.ObtenerListaClsCaballoCompletaBl();
            List<ClsRaza> listadoRazas = ListadoClsRazaBL.ObtenerListaCompletaClsRazasBL();
            listadoCaballosConListaRazas = new ObservableCollection<ClsCaballoConRazas>();

            foreach (ClsCaballo caballo in listadoCaballos)
            {
                ClsCaballoConRazas nuevoCaballo = new ClsCaballoConRazas(caballo, listadoRazas);
                listadoCaballosConListaRazas.Add(nuevoCaballo);
            }

        }
    }
}
