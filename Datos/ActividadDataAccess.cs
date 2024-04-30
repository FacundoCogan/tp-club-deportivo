
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
            const string query = "SELECT A.*, p.DNI as ProfesorDNI, P.Nombre AS ProfesorNombre, P.Apellido AS ProfesorApellido, p.Especialidad " +
                                 "FROM Actividades A " +
                                 "INNER JOIN Profesores P ON A.ProfesorDNI = P.DNI " +
                                 "WHERE A.Activo = ?";

            return ExecuteQuery(query, new OleDbParameter("Activo", true));
        }


        public bool Insert(string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo, int profesorDNI)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Descripcion", descripcion),
                new OleDbParameter("DiasHorarios", diasHorarios),
                new OleDbParameter("Costo", costo),
                new OleDbParameter("CupoMaximo", cupoMaximo),
                new OleDbParameter("ProfesorDNI", profesorDNI)
            };

            return Insert(parameters);
        }
    }
}