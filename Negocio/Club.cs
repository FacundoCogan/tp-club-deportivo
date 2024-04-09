using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Club
    {
        public List<Socio> Socios { get; } = new List<Socio>();
        public List<Profesor> Profesores { get; } = new List<Profesor>();
        public List<Actividad> Actividades { get; } = new List<Actividad>();

        public void AgregarActividad(Actividad actividad) { }
        public void EditarActividad(Actividad actividad) { }
        public void EliminarActividad(Actividad actividad) { }

        public void CrearSocio(string dni, string nombre, string apellido)
        {
            if (Socios.Exists(s => s.DNI == dni))
            {
                throw new Exception("Ya existe un socio con ese DNI");
            }

            Socios.Add(new Socio
            {
                DNI = dni,
                Nombre = nombre,
                Apellido = apellido
            });
        }

        public void EditarSocio(string nombre, string apellido)
        {

        }

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
