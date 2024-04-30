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

        public bool Agregar(SocioClub socio)
        {
            return _socioDataAccess.Insert(socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
        }

        public List<SocioClub> GetAllSocios()
        {
            var dataTable = _socioDataAccess.GetAllSocios();

            return (from DataRow row in dataTable.Rows
                    select new SocioClub(row.Field<int>("DNI"), row.Field<string>("Nombre"),
                        row.Field<string>("Apellido"), row.Field<decimal>("CuotaSocial"))).ToList();
        }

        public bool Editar(SocioClub socio)
        {
            return _socioDataAccess.Update(socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
        }

        public bool Eliminar(int dni)
        {
            return _socioDataAccess.Delete(dni);
        }
    }
}