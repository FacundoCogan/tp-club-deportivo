using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Datos;
using Negocio.Modelos;

namespace Negocio.BLL
{
    public class InscripcionBusiness
    {
        private readonly ActividadDataAccess _actividadDataAccess = new ActividadDataAccess();
        private readonly InscripcionDataAccess _inscripcionDataAccess = new InscripcionDataAccess();
        private readonly SocioDataAccess _socioDataAccess = new SocioDataAccess();

        public List<Actividad> GetActividadesSocio(int idSocio)
        {
            var dataTable = _actividadDataAccess.GetAllActividadesSocio(idSocio);

            return (from DataRow row in dataTable.Rows
                    select new Actividad(row.Field<int>("ID"), row.Field<string>("Nombre")))
                .ToList();
        }

        public List<Actividad> GetActividadesDisponiblesSocio(int idSocio)
        {
            var dataTable = _actividadDataAccess.GetAllActividadesDisponiblesSocio(idSocio);

            return (from DataRow row in dataTable.Rows
                    select new Actividad(row.Field<int>("ID"), row.Field<string>("Nombre")))
                .ToList();
        }

        public bool InscribirSocioEnActividad(int idSocio, int actividadId)
        {
            var socio = _socioDataAccess.GetById(idSocio);
            var actividad = _actividadDataAccess.GetById(actividadId);

            if (socio == null || actividad == null)
            {
                throw new Exception("Socio o actividad no encontrados.");
            }

            return _inscripcionDataAccess.Insert(idSocio, actividadId);
        }

        public bool DarBajaSocio(int idSocio)
        {
            var socio = _socioDataAccess.GetById(idSocio);

            return socio == null
                ? throw new Exception("Socio no encontrado.")
                : _inscripcionDataAccess.DeleteWhereSocio(idSocio);
        }

        public bool DarBajaActividad(int actividadId)
        {
            var actividad = _actividadDataAccess.GetById(actividadId);

            return actividad == null
                ? throw new Exception("Actividad no encontrada.")
                : _inscripcionDataAccess.DeleteWhereActividad(actividadId);
        }

        public bool DarBajaSocioActividad(int idSocio, int actividadId)
        {
            var socio = _socioDataAccess.GetById(idSocio);
            var actividad = _actividadDataAccess.GetById(actividadId);

            if (socio == null || actividad == null)
            {
                throw new Exception("Socio o actividad no encontrados.");
            }

            return _inscripcionDataAccess.Delete(idSocio, actividadId);
        }
    }
}