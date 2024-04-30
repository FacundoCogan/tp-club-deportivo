
using System.Data;

namespace Datos
{
    public class ProfesorDataAccess : PersonaDataAccess
    {
        public ProfesorDataAccess() : base("Profesores")
        {
        }

        public DataTable GetAllProfesores()
        {
            return GetAll();
        }




    }
}