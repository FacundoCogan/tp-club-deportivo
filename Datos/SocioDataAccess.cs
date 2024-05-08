using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class SocioDataAccess : PersonaDataAccess
    {
        public SocioDataAccess() : base("Socios")
        {
        }

        public DataTable GetAllSocios()
        {
            return GetAll();
        }

        public bool Insert(int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            if (Exists(dni))
            {
                throw new DuplicateNameException("Ya existe un socio con ese DNI");
            }

            return Insert(dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
        }

        public bool Update(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            return Update(id, dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
        }
    }
}