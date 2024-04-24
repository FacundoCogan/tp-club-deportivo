using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Actividad
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DiasHorarios { get; set; }
        public double Costo { get; set; }
        public int CupoMaximo { get; set; }
        //private Profesor profesor;
        public List<Socio> Participantes { get; set; }

        public Actividad(string n, string d, string dh, double c, int cm /*Profesor p*/)
        {
            Nombre = n;
            Descripcion = d;
            DiasHorarios = dh;
            Costo = c;
            CupoMaximo = cm;
            //profesor = p;
            Participantes = new List<Socio>();
        }

        public bool ConsultarDisponibilidad() { return false; }
        public void InscribirParticipante(Socio socio) { }
        public void DarBajaParticipante(Socio socio) { }
        public void VerParticipantes() { }
    }

}
