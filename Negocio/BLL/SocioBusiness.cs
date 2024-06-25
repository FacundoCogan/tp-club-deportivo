using System.Collections.Generic;
using System.Data;
using System.Linq;
using Datos;
using Negocio.Modelos;

namespace Negocio.BLL
{
    public class SocioBusiness
    {
        private readonly SocioDataAccess _socioDataAccess = new SocioDataAccess();

        public bool Agregar(Socio socio)
        {
            return _socioDataAccess.Insert(socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
        }

        private static Socio MapSocio(DataRow row)
        {
            var cuotaSocial = row.IsNull("CuotaSocial") ? null : row.Field<decimal?>("CuotaSocial");

            return cuotaSocial != null
                ? new SocioClub(
                    row.Field<int>("ID"),
                    row.Field<int>("DNI"),
                    row.Field<string>("Nombre"),
                    row.Field<string>("Apellido"),
                    cuotaSocial)
                : (Socio)new SocioActividad(
                    row.Field<int>("ID"),
                    row.Field<int>("DNI"),
                    row.Field<string>("Nombre"),
                    row.Field<string>("Apellido"));
        }

        public List<Socio> GetSociosSinPagar()
        {
            var dataTable = _socioDataAccess.GetSociosSinPagar();

            return (from DataRow row in dataTable.Rows
                    select MapSocio(row)).ToList();
        }

        public List<Socio> GetSociosSinOrden()
        {
            var dataTable = _socioDataAccess.GetSociosSinOrden();

            return (from DataRow row in dataTable.Rows
                    select MapSocio(row)).ToList();
        }

        public List<Socio> GetAllSocios()
        {
            var dataTable = _socioDataAccess.GetAllSocios();

            return (from DataRow row in dataTable.Rows
                    select MapSocio(row)).ToList();
        }

        public bool Pagar(OrdenPago ordenPago)
        {
            return _socioDataAccess.Pagar(ordenPago.ID, ordenPago.SocioID);
        }

        public bool Editar(Socio socio)
        {
            return _socioDataAccess.Update(socio.ID, socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
        }

        public bool Eliminar(int id)
        {
            return _socioDataAccess.Delete(id);
        }
    }
}