using System.Collections.Generic;
using Negocio.BLL;

namespace Negocio.Modelos
{
    public class Club
    {
        private readonly ActividadBusiness _actividades = new ActividadBusiness();
        private readonly ProfesorBusiness _profesores = new ProfesorBusiness();
        private readonly SocioBusiness _socios = new SocioBusiness();


        public List<SocioClub> Socios => _socios.GetAllSocios();

        public List<Profesor> Profesores => _profesores.GetAllProfesores();

        //public List<Profesor> ProfesoresDetallado => _profesores.GetAllProfesoresDetallado();
        public List<Actividad> Actividades => _actividades.GetAllActividadesBasico();
        public List<Actividad> ActividadesDetallado => _actividades.GetAllActividadesDetallado();


        public void AgregarActividad(string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int profesorDNI)
        {
            _actividades.Agregar(new Actividad(nombre, descripcion, diasHorarios, costo, cupoMaximo), profesorDNI);
        }


        public void EditarActividad(Actividad actividad)
        {
        }

        public void EliminarActividad(Actividad actividad)
        {
        }

        public void CrearSocio(int dni, string nombre, string apellido, decimal cuotaSocial)
        {
            _socios.Agregar(new SocioClub(dni, nombre, apellido, cuotaSocial));
        }

        public void EditarSocio(int dni, string nombre, string apellido, decimal cuotaSocial)
        {
            _socios.Editar(new SocioClub(dni, nombre, apellido, cuotaSocial));
        }

        public bool DarBajaSocio(int dniSocio)
        {
            return _socios.Eliminar(dniSocio);
        }

        public bool CrearProfesor(int dni, string nombre, string apellido, string especialidad)
        {
            return _profesores.Agregar(new Profesor(dni, nombre, apellido, especialidad));
        }

        public bool EditarProfesor(int dni, string nombre, string apellido, string especialidad)
        {
            return _profesores.Editar(new Profesor(dni, nombre, apellido, especialidad));
        }

        public void DarBajaProfesor(int dniProfesor)
        {
            _profesores.Eliminar(dniProfesor);
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

        public OrdenPago GenerarOrdenPagoSocio(Socio socio)
        {
            return null;
        } // Placeholder for payment order generation

        public void GenerarOrdenesPagoSocios()
        {
        }

        public void RegistrarPagoSocio(Socio socio, OrdenPago ordenPago)
        {
        }
    }
}