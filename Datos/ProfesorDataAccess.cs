using System.Data;
using System.Data.OleDb;

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

        public bool Insert(int dni, string nombre, string apellido, string especialidad)
        {
            return Insert(dni, nombre, apellido, new OleDbParameter("Especialidad", especialidad));
        }

        public bool Update(int dni, string nombre, string apellido, string especialidad)
        {
            return Update(dni, nombre, apellido, new OleDbParameter("Especialidad", especialidad));
        }
    }
}