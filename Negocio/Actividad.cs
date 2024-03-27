using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Actividad
    {
        public string Descripcion { get; set; }
        public string DiasHorarios { get; set; }
        public double Costo { get; set; }
        public int CupoMaximo { get; set; }
        public Profesor Profesor { get; set; }
        public List<Socio> Participantes { get; set; }

        public Actividad()
        {
            Participantes = new List<Socio>();
        }

        public bool ConsultarDisponibilidad() { return false; }
        public void InscribirParticipante(Socio socio) { }
        public void DarBajaParticipante(Socio socio) { }
        public void VerParticipantes() { }
    }

}
