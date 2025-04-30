using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ENT;
using MAUIRivals.Models.Utils;

namespace MAUIRivals.VM
{
    public class ListadoHeroesVillanosConPuntosVM : INotifyPropertyChanged
    {
        
        private ObservableCollection<ClsHeroeVillanoConPuntos> listaHeroesVillanosConPuntos;
        public event PropertyChangedEventHandler PropertyChanged;
        //private DelegateCommand actualizarLista;

        public ObservableCollection<ClsHeroeVillanoConPuntos> ListaHeroesVillanosConPuntos
        {
            get { return listaHeroesVillanosConPuntos; }
            
        }

        //public DelegateCommand ActualizarLista
        //{
        //    get { return actualizarLista; }
        //}

        public ListadoHeroesVillanosConPuntosVM()
        {
            // En el constructor ya no es necesario rellenar la lista desde la base de datos, por que en el 'OnAppearing()' ya se está rellenando


                //try
                //{
                //    listaHeroesVillanosConPuntos = new ObservableCollection<ClsHeroeVillanoConPuntos>(BL.ListadoHeroesVillanosConPuntos.obtenerListadoCompletoConPuntos());
                //}
                //catch (Exception ex)
                //{
                //    muestraMensajes("Error inesperado:", "No se pudo obtener el listado de personajes de la Base de Datos, vuelva a intentarlo más tarde", "Entendido");

                //}
        }


        #region TASK
        
        // Estuve mirando documentación y para poder llamar desde el OnAppearing
        /// <summary>
        /// Función que creará una lista en la MEMORIA para añadirlo en nuestra lista
        /// </summary>
        /// <returns></returns>
        public async Task actualizacionLista()
        {
            try
            {
                //Casteamos y llamamos a la Base de Datos para traernos la lista completa de heroes y villanos NUEVA
                //ObservableCollection<ClsHeroeVillanoConPuntos> nuevaLista = new ObservableCollection<ClsHeroeVillanoConPuntos>(BL.ListadoHeroesVillanosConPuntos.obtenerListadoCompletoConPuntos());



                listaHeroesVillanosConPuntos = new ObservableCollection<ClsHeroeVillanoConPuntos>(BL.ListadoHeroesVillanosConPuntos.obtenerListadoCompletoConPuntos());
                NotifyPropertyChanged(nameof(ListaHeroesVillanosConPuntos));
                

                // Pienso que como no tengo set en la propiedad 'listaHeroesVillanosConPuntos', no puedo machacarlo, por lo que limpio el contenido que tiene con el '.Clear()'
                // y por cada elemento que tenga la ' lo meto en la 'listaHeroeVillanosConPuntos' para que lo muestre
                
                //if (listaHeroesVillanosConPuntos != null)
                //{
                //    listaHeroesVillanosConPuntos.Clear();
                //}
                //foreach (ClsHeroeVillanoConPuntos heroe in nuevaLista)
                //{
                //    listaHeroesVillanosConPuntos.Add(heroe);
                //}


            
            }catch(Exception ex)
            {
                muestraMensajes("Error:", "No se pudo realizar la actualización correctamente. Intentelo mas tarde", "Entendido");
            }

        }

        #endregion

        #region INotifyPropertyChanged


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

        #region DisplayAlert function
        private async void muestraMensajes(string cabecera, string mensaje, string confirmacion)
        {
            await Shell.Current.DisplayAlert(cabecera, mensaje, confirmacion);
        }
        #endregion

    }
}
