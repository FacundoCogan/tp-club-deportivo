using System;
using System.Collections.Generic;
using Negocio.BLL;

namespace Negocio.Modelos
{
    public class Club
    {
        private readonly ActividadBusiness _actividades = new ActividadBusiness();
        private readonly InscripcionBusiness _inscripciones = new InscripcionBusiness();
        private readonly OrdenPagoBusiness _ordenPago = new OrdenPagoBusiness();
        private readonly ProfesorBusiness _profesores = new ProfesorBusiness();
        private readonly SocioBusiness _socios = new SocioBusiness();

        public List<Socio> Socios => _socios.GetAllSocios();
        public List<Socio> SociosSinPagar => _socios.GetSociosSinPagar();

        public List<Socio> SociosSinOrden => _socios.GetSociosSinOrden();

        public List<Profesor> Profesores => _profesores.GetAllProfesores();

        //public List<Profesor> ProfesoresDetallado => _profesores.GetAllProfesoresDetallado();
        public List<Actividad> Actividades => _actividades.GetAllActividadesBasico();
        public List<Actividad> ActividadesDetallado => _actividades.GetAllActividadesDetallado();

        public List <OrdenPago> GetOrdenesPendientes(int idSocio)
        {
            return _ordenPago.GetOrdenesPendientes(idSocio);
        }

        public List<Actividad> GetActividadesDisponiblesSocio(int idSocio)
        {
            return _inscripciones.GetActividadesDisponiblesSocio(idSocio);
        }

        public bool AgregarActividad(string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int profesorID)
        {
            return _actividades.Agregar(new Actividad(nombre, descripcion, diasHorarios, costo, cupoMaximo),
                profesorID);
        }

        public bool EditarActividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int profesorID)
        {
            return _actividades.Editar(new Actividad(id, nombre, descripcion, diasHorarios, costo, cupoMaximo),
                profesorID);
        }

        public bool EliminarActividad(int idActividad)
        {
            _inscripciones.DarBajaActividad(idActividad);

            return _actividades.Eliminar(idActividad);
        }

        public bool CrearSocio(int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            return _socios.Agregar(new Socio(dni, nombre, apellido, cuotaSocial));
        }

        public bool EditarSocio(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            return _socios.Editar(new Socio(id, dni, nombre, apellido, cuotaSocial));
        }

        public bool DarBajaSocio(int idSocio)
        {
            _inscripciones.DarBajaSocio(idSocio);

            return _socios.Eliminar(idSocio);
        }

        public bool CrearProfesor(int dni, string nombre, string apellido, string especialidad)
        {
            return _profesores.Agregar(new Profesor(dni, nombre, apellido, especialidad));
        }

        public bool EditarProfesor(int id, int dni, string nombre, string apellido, string especialidad)
        {
            return _profesores.Editar(new Profesor(id, dni, nombre, apellido, especialidad));
        }

        public bool DarBajaProfesor(int idProfesor)
        {
            return _profesores.Eliminar(idProfesor);
        }

        public List<Actividad> ConsultarActividadesSocio(int idSocio)
        {
            return _inscripciones.GetActividadesSocio(idSocio);
        }

        public List<Actividad> ConsultarActividadesProfesor(int idProfesor)
        {
            return _actividades.GetActividadesProfesor(idProfesor);
        }

        public bool InscribirSocioActividad(int idSocio, int idActividad)
        {
            return _inscripciones.InscribirSocioEnActividad(idSocio, idActividad);
        }

        public bool DarBajaSocioActividad(int idSocio, int idActividad)
        {
            return _inscripciones.DarBajaSocioActividad(idSocio, idActividad);
        }

        public bool GenerarOrdenPagoSocio(Socio socio)
        {
            var monto = socio.CalcularMontoOrdenPago();

            return _ordenPago.Agregar(new OrdenPago(socio.ID, monto));
        }

        public void GenerarOrdenesPagoSocios()
        {   
            foreach (var socio in SociosSinOrden)
            {
                GenerarOrdenPagoSocio(socio);
            }
        }

        public void RegistrarPagoSocio(OrdenPago ordenPago)
        {
            _socios.Pagar(ordenPago);
        }

    }
}