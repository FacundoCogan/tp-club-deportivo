
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

        public bool Insert(int dni, string nombre, string apellido, decimal cuotaSocial)
        {
            return Insert(dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
        }

        public bool Update(int dni, string nombre, string apellido, decimal cuotaSocial)
        {
            return Update(dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
        }
    }
}