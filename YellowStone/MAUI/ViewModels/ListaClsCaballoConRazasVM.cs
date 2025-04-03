using BL;
using ENT;
using MAUI.Models;
using Microsoft.Data.SqlClient;
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

        private void actualizar_execute()
        {
            // TODO: Código que se encargará de recorrer la lista para actualizar las razas
            int filasTotalesafectadas = 0;
            int numFilasAfectadas = 0;
            List<ClsCaballo> listadoCaballos = new();
            List<ClsRaza> listadoRazas = new();


            foreach (ClsCaballoConRazas caballo in ListadoCaballosConListaRazas)
            {
                if(caballo.IdRaza != caballo.RazaSelected.IdRaza && caballo.RazaSelected.IdRaza != 0)
                {
                    try
                    {

                        // Trabajando con la conexion a la Base de Datos
                        var resultado = ManejadoraBL.actualizarListaRazaCaballoBL(caballo.IdCaballo, caballo.RazaSelected.IdRaza); //Devuelve una tupla
                        listadoCaballos = resultado.Item2;
                        numFilasAfectadas = resultado.Item1;

                        
                        // Trabajando con una lista en la capa DAL
                        //numFilasAfectadas = ManejadoraBL.actualizarRazaCaballoBL(caballo.IdCaballo, caballo.RazaSelected.IdRaza); 
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
 

            muestraMensajes("Operación realizada!",$"El número de filas afectadas es de: {filasTotalesafectadas}","Confirmar");


            // ACTUALIZACIÓN DE LA LISTA QUE TENEMOS EN LA RAM

            try
            {
                listadoRazas = ListadoClsRazaBL.ObtenerListaCompletaClsRazasBL();
            }
            catch (SqlException e)
            {
                muestraMensajes("Error", "Ha ocurrido un error inesperado, pruebelo más tarde.", "Entendido :(");
            }

            ListadoCaballosConListaRazas.Clear();

            foreach (ClsCaballo caballo in listadoCaballos)
            {
                ClsCaballoConRazas newCaballito = new ClsCaballoConRazas(caballo, listadoRazas);
                ListadoCaballosConListaRazas.Add(newCaballito);
            }
            

        }
        #endregion
        #region DisplayAlert function
        public async void muestraMensajes(String cabecera, String mensaje, String confirmacion)
        {
            await Shell.Current.DisplayAlert(cabecera, mensaje, confirmacion);
        }
        #endregion
    }
}
