using ENT;
namespace DTO
{
    public class PersonaConCheck : ClsPersona
    {
        private Boolean esMayor;

        public Boolean EsMayor
        {
            get { return esMayor; }
        }

        public PersonaConCheck(ClsPersona persona) : base(persona.IdPersona, persona.Nombre, persona.Apellido, persona.FechaNacimiento)
        {
            
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaNacimiento = persona.FechaNacimiento;

            int edad = fechaHoy.Year - fechaNacimiento.Year;

            if(fechaNacimiento.DayOfYear > fechaHoy.DayOfYear)
            {
                edad--;
            }

            this.esMayor = edad >= 18;
        }
    }
}
