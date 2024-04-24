using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Club
    {
        public List<Socio> Socios { get; } = new List<Socio>();
        public List<Profesor> Profesores { get; } = new List<Profesor>();
        public List<Actividad> Actividades { get; } = new List<Actividad>();

        // ------------------------ MÉTODOS ------------------------ //

        public void AgregarActividad(Actividad actividad) 
        {

            if (Actividades.Exists(a => a.Nombre == actividad.Nombre))
            {
                throw new Exception("Ya existe una actividad con ese nombre");
            }
            else

                Actividades.Add(actividad);

        }
        public void EditarActividad(Actividad act, int i)
        {
            Actividades[i] = act;
        }


        public Actividad BuscarActividad(string actividad)
        {
            Actividad act = Actividades.Find(a => a.Nombre.ToString() == actividad);
            if(act != null)
                return act;
            else
                throw new Exception("No se encontró la actividad");

        }

        public int BuscarIndice(Actividad act)
        {
            return Actividades.IndexOf(act);
        }

        public void EliminarActividad(int i) 
        {
            Actividades.RemoveAt(i);
        }

        public void CrearSocio(Socio socio)
        {
            if (Socios.Exists(s => s.DNI == socio.DNI))
            {
                throw new Exception("Ya existe un socio con ese DNI");
            }

            Socios.Add(socio);
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
