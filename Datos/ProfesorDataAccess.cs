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
            if (Exists(dni))
            {
                throw new DuplicateNameException("Ya existe un profesor con ese DNI.");
            }

            return Insert(dni, nombre, apellido, new OleDbParameter("Especialidad", especialidad));
        }

        public bool Update(int id, int dni, string nombre, string apellido, string especialidad)
        {
            if (ExistsOtherThan(id, new OleDbParameter("DNI", dni)))
            {
                throw new DuplicateNameException("Ya existe un profesor con ese DNI");
            }

            return Update(id, dni, nombre, apellido, new OleDbParameter("Especialidad", especialidad));
        }
    }
}