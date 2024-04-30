using System.Collections.Generic;
using System.Data;
using System.Linq;
using Datos;
using Negocio.Modelos;

namespace Negocio.BLL
{
    public class ProfesorBusiness
    {
        private readonly ProfesorDataAccess _profesorDataAccess = new ProfesorDataAccess();


        public Profesor GetByDNI(int dni)
        {
            var profesorDataRow = _profesorDataAccess.GetByDNI(dni);

            return new Profesor(profesorDataRow.Field<int>("DNI"), profesorDataRow.Field<string>("Nombre"), profesorDataRow.Field<string>("Apellido"), profesorDataRow.Field<string>("Especialidad")); ;
        }

        public List<Profesor> GetAllProfesores()
        {
            var dataTable = _profesorDataAccess.GetAllProfesores();

            return (from DataRow row in dataTable.Rows select new Profesor(row.Field<int>("DNI"), row.Field<string>("Nombre"), row.Field<string>("Apellido"), row.Field<string>("Especialidad"))).ToList();
        }

        //public List<Profesor> GetAllProfesoresDetallado()
        //{
        //    var dataTable = _profesorDataAccess.GetAllProfesoresDetallado();

        //    return (from DataRow row in dataTable.Rows select new Profesor(row.Field<int>("DNI"), row.Field<string>("Nombre"), row.Field<string>("Apellido"), row.Field<string>("Especialidad"), row.Field<string>("Actividades"))).ToList();
        //}
    }
}
