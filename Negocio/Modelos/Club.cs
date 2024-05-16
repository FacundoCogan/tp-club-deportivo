using System.Collections.Generic;
using Negocio.BLL;

namespace Negocio.Modelos
{
    public class Club
    {
        private readonly ActividadBusiness _actividades = new ActividadBusiness();
        private readonly OrdenPagoBusiness _ordenPago = new OrdenPagoBusiness();
        private readonly ProfesorBusiness _profesores = new ProfesorBusiness();
        private readonly SocioBusiness _socios = new SocioBusiness();


        public List<Socio> Socios => _socios.GetAllSocios();

        public List<Profesor> Profesores => _profesores.GetAllProfesores();

        //public List<Profesor> ProfesoresDetallado => _profesores.GetAllProfesoresDetallado();
        public List<Actividad> Actividades => _actividades.GetAllActividadesBasico();
        public List<Actividad> ActividadesDetallado => _actividades.GetAllActividadesDetallado();


        public void AgregarActividad(string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int profesorID)
        {
            _actividades.Agregar(new Actividad(nombre, descripcion, diasHorarios, costo, cupoMaximo), profesorID);
        }


        public void EditarActividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int profesorID)
        {
            _actividades.Editar(new Actividad(id, nombre, descripcion, diasHorarios, costo, cupoMaximo), profesorID);
        }

        public void EliminarActividad(int ID)
        {
            _actividades.Eliminar(ID);
        }

        public void CrearSocio(int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            _socios.Agregar(new Socio(dni, nombre, apellido, cuotaSocial));
        }

        public void EditarSocio(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
        {
            _socios.Editar(new Socio(id, dni, nombre, apellido, cuotaSocial));
        }

        public bool DarBajaSocio(int idSocio)
        {
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

        public void ConsultarActividades()
        {
        }

        public void InscribirSocioActividad(Socio socio, Actividad actividad)
        {
        }

        public void DarBajaSocioActividad(Socio socio, Actividad actividad)
        {
        }

        public bool GenerarOrdenPagoSocio(Socio socio)
        {
            var monto = socio.CalcularMontoOrdenPago();

            return _ordenPago.Agregar(new OrdenPago(socio.ID, monto));
        }

        public void GenerarOrdenesPagoSocios()
        {
        }

        public void RegistrarPagoSocio(Socio socio, OrdenPago ordenPago)
        {
        }
    }
}