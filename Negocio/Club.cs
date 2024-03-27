using System.Collections.Generic;

namespace Negocio
{
    public class Club
    {
        public List<Socio> Socios { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Actividad> Actividades { get; set; }

        public Club()
        {
            Socios = new List<Socio>();
            Profesores = new List<Profesor>();
            Actividades = new List<Actividad>();
        }

        public void AgregarActividad(Actividad actividad) { }
        public void EditarActividad(Actividad actividad) { }
        public void EliminarActividad(Actividad actividad) { }

        public void CrearSocio(Socio socio)
        {

            Socios.Add(socio);
        }

        public void EditarSocio(Socio socio) { }
        public void DarBajaSocio(Socio socio) { }
        public void CrearProfesor(Profesor profesor) { }
        public void EditarProfesor(Profesor profesor) { }
        public void DarBajaProfesor(Profesor profesor) { }
        public void ConsultarActividades() { }
        public void InscribirSocioActividad(Socio socio, Actividad actividad) { }
        public void DarBajaSocioActividad(Socio socio, Actividad actividad) { }
        public OrdenPago GenerarOrdenPagoSocio(Socio socio) { return null; } // Placeholder for payment order generation
        public void GenerarOrdenesPagoSocios() { }
        public void RegistrarPagoSocio(Socio socio, OrdenPago ordenPago) { }
    }

}
