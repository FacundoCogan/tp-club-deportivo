using System.Collections.Generic;
using Negocio.BLL;

namespace Negocio.Modelos
{
    public class Club
    {
        private readonly ActividadBusiness _actividad = new ActividadBusiness();
        private readonly InscripcionBusiness _inscripcion = new InscripcionBusiness();
        private readonly OrdenPagoBusiness _ordenPago = new OrdenPagoBusiness();
        private readonly ProfesorBusiness _profesor = new ProfesorBusiness();
        private readonly SocioBusiness _socio = new SocioBusiness();

        public List<Socio> Socios => _socio.GetAllSocios();
        public List<Socio> SociosSinPagar => _socio.GetSociosSinPagar();
        public List<Socio> SociosSinOrden => _socio.GetSociosSinOrden();
        public List<Profesor> Profesores => _profesor.GetAllProfesores();
        public List<Actividad> Actividades => _actividad.GetAllActividades();
        public int OrdenesImpagas => _ordenPago.GetOrdenesImpagas();

        public List<Socio> GetParticipantesActividad(int idActividad)
        {
            return _inscripcion.GetParticipantesActividad(idActividad);
        }

        public List<OrdenPago> GetOrdenesPendientes(int idSocio)
        {
            return _ordenPago.GetOrdenesPendientes(idSocio);
        }

        public List<Actividad> GetActividadesDisponiblesSocio(int idSocio)
        {
            return _inscripcion.GetActividadesDisponiblesSocio(idSocio);
        }

        public bool AgregarActividad(string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int idProfesor)
        {
            return _actividad.Agregar(new Actividad(nombre, descripcion, diasHorarios, costo, cupoMaximo),
                idProfesor);
        }

        public bool EditarActividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int idProfesor)
        {
            return _actividad.Editar(new Actividad(id, nombre, descripcion, diasHorarios, costo, cupoMaximo),
                idProfesor);
        }

        public bool EliminarActividad(int idActividad)
        {
            _inscripcion.DarBajaActividad(idActividad);

            return _actividad.Eliminar(idActividad);
        }

        public Socio BuscarUsuario(string usuario)
        {
            return _socio.GetSocioPorUsuario(usuario);
        }

        public bool CrearSocio(int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            return _socio.Agregar(new Socio(dni, nombre, apellido, cuotaSocial));
        }

        public bool EditarSocio(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            return _socio.Editar(new Socio(id, dni, nombre, apellido, cuotaSocial));
        }

        public bool DarBajaSocio(int idSocio)
        {
            _inscripcion.DarBajaSocio(idSocio);

            return _socio.Eliminar(idSocio);
        }

        public bool CrearProfesor(int dni, string nombre, string apellido, string especialidad)
        {
            return _profesor.Agregar(new Profesor(dni, nombre, apellido, especialidad));
        }

        public bool EditarProfesor(int id, int dni, string nombre, string apellido, string especialidad)
        {
            return _profesor.Editar(new Profesor(id, dni, nombre, apellido, especialidad));
        }

        public bool DarBajaProfesor(int idProfesor)
        {
            return _profesor.Eliminar(idProfesor);
        }

        public List<Actividad> ConsultarActividadesSocio(int idSocio)
        {
            return _inscripcion.GetActividadesSocio(idSocio);
        }

        public List<Actividad> ConsultarActividadesProfesor(int idProfesor)
        {
            return _actividad.GetActividadesProfesor(idProfesor);
        }

        public bool InscribirSocioActividad(int idSocio, int idActividad)
        {
            return _inscripcion.InscribirSocioEnActividad(idSocio, idActividad);
        }

        public bool DarBajaSocioActividad(int idSocio, int idActividad)
        {
            return _inscripcion.DarBajaSocioActividad(idSocio, idActividad);
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
            _socio.Pagar(ordenPago);
        }
    }
}