using System;
using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class OrdenPagoDataAccess : DataAccessBase
    {
        public OrdenPagoDataAccess() : base("OrdenesPago")
        {
        }

        public DataTable GetOrdenesPendientes(int idSocio)
        {
            const string query = "SELECT * FROM OrdenesPago WHERE Pagada = FALSE AND SocioID = ?";

            return ExecuteQuery(query, new OleDbParameter("SocioID", idSocio));
        }

        public bool Insert(int idSocio, decimal monto)
        {
            // Verificar si ya existe una orden de pago para el mismo cliente en el mismo mes y año
            var query = "SELECT COUNT(*) FROM OrdenesPago WHERE SocioID = ? AND MONTH(Fecha) = ? AND YEAR(Fecha) = ?";
            var count = 0;

            using (var connection = new OleDbConnection(_connectionString))
            {
                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("SocioID", idSocio);
                    command.Parameters.AddWithValue("Month", DateTime.Now.Month);
                    command.Parameters.AddWithValue("Year", DateTime.Now.Year);

                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            // Si ya existe una orden de pago para el mismo cliente en el mismo mes y año, no se inserta una nueva orden
            if (count > 0)
            {
                throw new DuplicateNameException(
                    "Ya existe una orden de pago para el mismo cliente en el mismo mes y año");
            }

            // Si no existe una orden de pago para el mismo cliente en el mismo mes y año, se inserta la nueva orden
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio),
                new OleDbParameter("Monto", monto)
            };

            return Insert(parameters);
        }


        public DataTable GetAllOrdenesPago()
        {
            return GetAll();
        }

        public bool Update(int id, int idSocio, DateTime fecha, decimal monto, bool pagada)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio),
                new OleDbParameter("Fecha", fecha),
                new OleDbParameter("Monto", monto),
                new OleDbParameter("Pagada", pagada)
            };

            return Update(parameters, "ID = ?", new OleDbParameter("ID", id));
        }

        public int GetOrdenesImpagas()
        {
            const string query = "SELECT COUNT(*) FROM OrdenesPago WHERE Pagada = FALSE";

            return (int)ExecuteScalar(query);
        }
    }
}