using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DTO;
using System.Collections.ObjectModel;

namespace MAUI.Models
{
    public class ListadoPersonaConCheckVM
    {
        private ObservableCollection<PersonaConCheck> listaConCheck;


        #region GET
        public ObservableCollection<PersonaConCheck> ListaConCheck
        {
            get { return listaConCheck; }
        }
        #endregion

        #region Constructor
        public ListadoPersonaConCheckVM()
        {
            listaConCheck = new ObservableCollection<PersonaConCheck>();
            listaConCheck = personasConCheck();
        }
        #endregion
        #region MetodoRellenar
        private static ObservableCollection<PersonaConCheck> personasConCheck()
        {
            List<ClsPersona> listadoPersonasDB = new List<ClsPersona>();
            ObservableCollection<PersonaConCheck> listadoPersonasCheck = new ObservableCollection<PersonaConCheck>();
            try
            {
                listadoPersonasDB = BL.ListadoPersonasBL.obtenerListadoCompletoBL();

            }catch(Exception ex)
            {
                throw new Exception("No se pudo obtener el listado en el MODELO", ex);
            }    


            foreach (ClsPersona personita in listadoPersonasDB)
            {
                PersonaConCheck nuevaPersonaConCheck = new PersonaConCheck(personita);
                listadoPersonasCheck.Add(nuevaPersonaConCheck);

            }
            return listadoPersonasCheck;
        }
        #endregion

    }
}
