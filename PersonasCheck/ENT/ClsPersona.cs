namespace ENT
{
    public class ClsPersona
    {
        private int idPersona;
        private String nombre;
        private String apellido;
        private DateTime fechaNacimiento;

        #region GETTERS Y SETTERS

        public int IdPersona
        {
            get { return idPersona; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        #endregion

        public ClsPersona()
        {
        }
        public ClsPersona(int nuevoID)
        {
            this.idPersona = nuevoID;
        }
        public ClsPersona(int nuevoID, String nuevoNombre, String nuevoApellido, DateTime fechaNac)
        {
            this.idPersona= nuevoID;
            this.Nombre = nuevoNombre;
            this.Apellido = nuevoApellido;
            this.FechaNacimiento = fechaNac;
        }
    }
}
