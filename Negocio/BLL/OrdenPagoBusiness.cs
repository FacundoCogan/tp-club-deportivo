using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Datos;
using Negocio.Modelos;

namespace Negocio.BLL
{
    public class OrdenPagoBusiness
    {
        private readonly OrdenPagoDataAccess _ordenPagoDataAccess = new OrdenPagoDataAccess();

        public bool Agregar(OrdenPago ordenPago)
        {
            return _ordenPagoDataAccess.Insert(ordenPago.SocioID, ordenPago.Monto);
        }

        public List<OrdenPago> GetOrdenesPendientes(int idSocio)
        {
            var dataTable = _ordenPagoDataAccess.GetOrdenesPendientes(idSocio);

            return (from DataRow row in dataTable.Rows
                    select new OrdenPago(
                        row.Field<int>("ID"),
                        row.Field<int>("SocioID"),
                        row.Field<decimal>("Monto"),
                        row.Field<DateTime>("Fecha"))).ToList();
        }

        public int GetOrdenesImpagas()
        {
            return _ordenPagoDataAccess.GetOrdenesImpagas();
        }
    }
}