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

        public DataTable GetAllOrdenesPago()
        {
            return GetAll();
        }

        public bool Insert(int idSocio, decimal monto)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("SocioID", idSocio),
                new OleDbParameter("Monto", monto)
            };

            return Insert(parameters);
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
    }
}