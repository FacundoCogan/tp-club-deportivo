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
        private readonly SocioDataAccess _socioDataAccess = new SocioDataAccess();

        public List<Actividad> GetActividadesDisponiblesSocio(int socioId)
        {
            var dataTable = _actividadDataAccess.GetAllActividadesDisponiblesSocio(socioId);

            return (from DataRow row in dataTable.Rows
                    select new Actividad(row.Field<int>("ID"), row.Field<string>("Nombre")))
                .ToList();
        }

        public bool InscribirSocioEnActividad(int socioId, int actividadId)
        {
            var socio = _socioDataAccess.GetById(socioId);
            var actividad = _socioDataAccess.GetById(actividadId);

            if (socio == null || actividad == null)
            {
                throw new Exception("Socio o actividad no encontrados.");
            }

            return _socioDataAccess.InscribirEnActividad(socioId, actividadId);
        }

        //public bool DesinscribirSocioEnActividad(int socioId, int actividadId)
        //{
        //    var socio = _socioDataAccess.GetById(socioId);
        //    var actividad = _socioDataAccess.GetById(actividadId);

        //    if (socio == null || actividad == null)
        //    {
        //        throw new Exception("Socio o actividad no encontrados.");
        //    }

        //    return _socioDataAccess.DesinscribirEnActividad(socioId, actividadId);
        //}
    }
}