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

        //int currentMonth = DateTime.Now.Month;
        //int currentYear = DateTime.Now.Year;

        public DataTable GetAllSocios()
        {
            return GetAll();
        }

        public DataTable GetSociosSinPagar()
        {
            //OleDbParameter[] parameters =
            //{
            //    new OleDbParameter("currentMonth", currentMonth),
            //    new OleDbParameter("currentYear", currentYear)
            //};

            string query = $"SELECT * FROM Socios WHERE ID IN (SELECT SocioID FROM OrdenesPago WHERE Pagada = FALSE)";

            return ExecuteQuery(query /*parameters*/);
        }

        public bool Pagar(int idOrdenPago, int socioID)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("ID", idOrdenPago),
                new OleDbParameter("SocioID", socioID)
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

            return Insert(dni, nombre, apellido, new OleDbParameter("CuotaSocial", cuotaSocial));
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