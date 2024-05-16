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
    }
}