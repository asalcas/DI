using BL;
using ENT;
using MAUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.utils;


namespace MAUI.ViewModels
{
    public class ListaClsCaballoConRazasVM  
    {
        //private DelegateCommand actualizarCommand; puede ser asi pero prefiero hacerlo autoimplementado
        public ObservableCollection<ClsCaballoConRazas> ListadoCaballosConListaRazas { get; }
        public DelegateCommand ActualizarCommand { get; } // Tenemos la propiedad publica Actualizar, para poder llevarlo al constructor


        /// <summary>
        /// Constructor de 'ListaClsCaballoConRazas' rellenando un ObservableCollection con objetos ClsCaballoConRazas
        /// </summary>
        public ListaClsCaballoConRazasVM()
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

                ActualizarCommand = new DelegateCommand(actualizar_execute); // actualizar_execute, será un método que será lo que realizará el usuario al darle al botón
            }
            catch (Exception e)
            {

                muestraMensajes("Error!", "No se pudo obtener los datos necesarios :(", "Ok");

            }
            

        }


        #region Métodos

        #endregion
        #region Comandos

        private async void actualizar_execute()
        {
            // TODO: Código que se encargará de recorrer la lista para actualizar las razas
            int filasTotalesafectadas = 0;
            int numFilasAfectadas = 0;

            foreach(ClsCaballoConRazas caballo in ListadoCaballosConListaRazas)
            {
                if(caballo.IdRaza != caballo.RazaSelected.IdRaza && caballo.RazaSelected.IdRaza != 0)
                {
                    try
                    {
                        numFilasAfectadas = ManejadoraBL.actualizarRazaCaballoBL(caballo.IdCaballo, caballo.RazaSelected.IdRaza);
                    }
                    catch (Exception e)
                    {
                        muestraMensajes("Error al conectar a la Base de Datos", "Intentelo más tarde", "Entendido");
                    }
                    
                    if (numFilasAfectadas == 1)
                    {
                        caballo.IdRaza = caballo.RazaSelected.IdRaza;
                        filasTotalesafectadas++;
                    }
                }
            }

           await Shell.Current.DisplayAlert("Operación realizada!",$"El número de filas afectadas es de: {filasTotalesafectadas}","Confirmar");
            //TODO: Actualizar la lista de ClsCaballos otra vez
        }
        #endregion
        public async void muestraMensajes(String cabecera, String mensaje, String confirmacion)
        {
            await Shell.Current.DisplayAlert(cabecera, mensaje, confirmacion);
        }
    }
}
