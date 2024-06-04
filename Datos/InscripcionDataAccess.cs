using System.Data.OleDb;

namespace Datos
{
    public class InscripcionDataAccess : DataAccessBase
    {
        public InscripcionDataAccess() : base("SociosActividades")
        {
        }

        public bool Insert(int idSocio, int idActividad)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio),
                new OleDbParameter("ActividadID", idActividad)
            };

            var query = $"INSERT INTO {TableName} (SocioID, ActividadID) VALUES (?, ?)";

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteWhereSocio(int idSocio)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio)
            };

            var query = $"DELETE FROM {TableName} WHERE SocioID = ?";

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteWhereActividad(int idActividad)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("ActividadID", idActividad)
            };

            var query = $"DELETE FROM {TableName} WHERE ActividadID = ?";

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int idSocio, int idActividad)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio),
                new OleDbParameter("ActividadID", idActividad)
            };

            var query = $"DELETE FROM {TableName} WHERE SocioID = ? AND ActividadID = ?";

            return ExecuteNonQuery(query, parameters) > 0;
        }
    }
}