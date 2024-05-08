using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class ActividadDataAccess : DataAccessBase
    {
        public ActividadDataAccess() : base("Actividades")
        {
        }

        public DataTable GetAllActividades()
        {
            return GetAll("Activo = ?", new OleDbParameter("Activo", true));
        }

        public DataTable GetAllActividadesDetallado()
        {
            const string query =
                "SELECT A.*, p.ID as ProfesorID, P.Nombre AS ProfesorNombre, P.Apellido AS ProfesorApellido, p.Especialidad " +
                "FROM Actividades A " +
                "INNER JOIN Profesores P ON A.ProfesorID = P.ID " +
                "WHERE A.Activo = ?";

            return ExecuteQuery(query, new OleDbParameter("Activo", true));
        }

        public bool Insert(string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo,
            int profesorID)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Descripcion", descripcion),
                new OleDbParameter("DiasHorarios", diasHorarios),
                new OleDbParameter("Costo", costo),
                new OleDbParameter("CupoMaximo", cupoMaximo),
                new OleDbParameter("ProfesorID", profesorID)
            };

            return Insert(parameters);
        }

        public bool Update(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo,
            int profesorID)
        {
            OleDbParameter[] baseParameters =
            {
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Descripcion", descripcion),
                new OleDbParameter("DiasHorarios", diasHorarios),
                new OleDbParameter("Costo", costo),
                new OleDbParameter("CupoMaximo", cupoMaximo),
                new OleDbParameter("ProfesorID", profesorID)
            };

            var whereParameter = new OleDbParameter("ID", id);

            return Update(baseParameters, "ID = ?", whereParameter);
        }

        public bool Delete(int ID)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("ID", ID)
            };

            return Delete("ID = ?", parameters);
        }
    }
}