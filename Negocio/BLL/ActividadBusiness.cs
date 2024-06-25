using System.Collections.Generic;
using System.Data;
using System.Linq;
using Datos;
using Negocio.Modelos;

namespace Negocio.BLL
{
    public class ActividadBusiness
    {
        private readonly ActividadDataAccess _actividaDataAccess = new ActividadDataAccess();

        public bool Agregar(Actividad actividad, int profesorID)
        {
            return _actividaDataAccess.Insert(actividad.Nombre, actividad.Descripcion, actividad.DiasHorarios,
                actividad.Costo, actividad.CupoMaximo, profesorID);
        }

        public bool Editar(Actividad actividad, int profesorID)
        {
            return _actividaDataAccess.Update(actividad.ID, actividad.Nombre, actividad.Descripcion,
                actividad.DiasHorarios,
                actividad.Costo, actividad.CupoMaximo, profesorID);
        }

        public bool Eliminar(int ID)
        {
            return _actividaDataAccess.Delete(ID);
        }

        public List<Actividad> GetAllActividades()
        {
            var dataTable = _actividaDataAccess.GetAllActividades();

            return (from DataRow row in dataTable.Rows
                    select new Actividad(row.Field<int>("ID"), row.Field<string>("Nombre"),
                        row.Field<string>("Descripcion"),
                        row.Field<string>("DiasHorarios"), row.Field<decimal>("Costo"), row.Field<int>("CupoMaximo"),
                        row.Field<int>("Disponibilidad")))
                .ToList();
        }

        public List<Actividad> GetActividadesProfesor(int profesorID)
        {
            var dataTable = _actividaDataAccess.GetAllActividadesProfesor(profesorID);

            return (from DataRow row in dataTable.Rows
                    select new Actividad(row.Field<int>("ID"), row.Field<string>("Nombre"),
                        row.Field<string>("Descripcion"),
                        row.Field<string>("DiasHorarios"), row.Field<decimal>("Costo"), row.Field<int>("CupoMaximo")))
                .ToList();
        }
    }
}