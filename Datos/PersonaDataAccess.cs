using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace Datos
{
    public abstract class PersonaDataAccess : DataAccessBase
    {
        protected PersonaDataAccess(string tableName) : base(tableName)
        {
        }

        public DataRow GetByDNI(int dni)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("DNI", dni)
            };

            var dt = GetBy("DNI = ? AND Activo = TRUE", parameters);

            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }

        protected DataTable GetAll()
        {
            return GetAll("Activo = TRUE");
        }

        public bool Delete(int dni)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("DNI", dni)
            };

            return Delete("DNI = ?", parameters);
        }

        public bool Insert(int dni, string nombre, string apellido, params OleDbParameter[] additionalParameters)
        {
            OleDbParameter[] baseParameters =
            {
                new OleDbParameter("DNI", dni),
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Apellido", apellido)
            };

            var combinedParameters = baseParameters.Concat(additionalParameters).ToArray();

            return Insert(combinedParameters);
        }

        public bool Update(int dni, string nombre, string apellido, params OleDbParameter[] additionalParameters)
        {
            OleDbParameter[] baseParameters =
            {
                new OleDbParameter("DNI", dni),
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Apellido", apellido)
            };

            var whereParameter = new OleDbParameter("WhereDNI", dni);

            var combinedParameters =
                baseParameters.Concat(additionalParameters).ToArray();

            return Update(combinedParameters, "DNI = ?", whereParameter);
        }
    }
}