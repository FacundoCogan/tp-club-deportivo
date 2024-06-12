using System;
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

        public DataTable GetSociosSinPagar()
        {
            return ExecuteQuery(
                "SELECT * FROM Socios WHERE ID IN (SELECT SocioID FROM OrdenesPago WHERE Pagada = FALSE)");
        }

        public DataTable GetSociosSinOrden()
        {
            var query =
                $"SELECT * FROM Socios WHERE ID NOT IN (SELECT SocioID FROM OrdenesPago WHERE MONTH(Fecha) = {DateTime.Now.Month} AND YEAR(Fecha) = {DateTime.Now.Year})";

            return ExecuteQuery(query);
        }

        public bool Pagar(int idOrdenPago, int idSocio)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("ID", idOrdenPago),
                new OleDbParameter("SocioID", idSocio)
            };

            const string query = "UPDATE OrdenesPago SET Pagada = TRUE WHERE ID = ? AND SocioID = ?";

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Insert(int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            if (Exists(dni))
            {
                throw new DuplicateNameException("Ya existe un socio con ese DNI");
            }

            var cuotaSocialParameter = new OleDbParameter("CuotaSocial", OleDbType.Decimal)
            {
                Value = cuotaSocial.HasValue ? (object)cuotaSocial.Value : DBNull.Value
            };

            return Insert(dni, nombre, apellido, cuotaSocialParameter);
        }

        public bool Update(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            if (ExistsOtherThan(id, new OleDbParameter("DNI", dni)))
            {
                throw new DuplicateNameException("Ya existe un socio con ese DNI");
            }

            return Update(id, dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
        }
    }
}