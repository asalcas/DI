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
        public ObservableCollection<ClsCaballoConRazas> ListadoCaballosConListaRazas { get; }
        


        /// <summary>
        /// Constructor de 'ListaClsCaballoConRazas' rellenando un ObservableCollection con objetos ClsCaballoConRazas
        /// </summary>
        public ListaClsCaballoConRazas()
        {
            try
            {
                List<ClsCaballo> listadoCaballos = ListadoClsCaballoBL.ObtenerListaClsCaballoCompletaBl();
                List<ClsRaza> listadoRazas = ListadoClsRazaBL.ObtenerListaCompletaClsRazasBL();
                ListadoCaballosConListaRazas = new ObservableCollection<ClsCaballoConRazas>();

                // Creamos una raza Predeterminada para poder introducir 
                ClsRaza razaPredeterminada = new ClsRaza(0, "--- SELECCIONA UNA RAZA ---");

                listadoRazas.Insert(0, razaPredeterminada);
                foreach (ClsCaballo caballo in listadoCaballos)
                {
                    ClsCaballoConRazas nuevoCaballo = new ClsCaballoConRazas(caballo, listadoRazas);
                    ListadoCaballosConListaRazas.Add(nuevoCaballo);
                }
            }
            catch (Exception e)
            {
                // TODO Avisar al usuario mediante un DisplayAlert que ha ocurrido un error
            }
            

        }
    }
}
