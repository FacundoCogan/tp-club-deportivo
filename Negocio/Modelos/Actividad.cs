using System.Collections.Generic;

namespace Negocio.Modelos
{
    public class Actividad
    {
        public Actividad(string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            DiasHorarios = diasHorarios;
            Costo = costo;
            CupoMaximo = cupoMaximo;
        }
        public Actividad(string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo,
            Profesor profesor) : this(nombre, descripcion, diasHorarios, costo, cupoMaximo)
        {
            Profesor = profesor;
        }

        // ------------------ Sobrecarga del constructor para que acepte el ID de la actividad ------------------
        public Actividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo)
        {
            ID = id;
            Nombre = nombre;
            Descripcion = descripcion;
            DiasHorarios = diasHorarios;
            Costo = costo;
            CupoMaximo = cupoMaximo;
        }
        public Actividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo,
            Profesor profesor) : this(id, nombre, descripcion, diasHorarios, costo, cupoMaximo)
        {
            Profesor = profesor;
        }
        // --------------------------------------------------------------------------------------------------------


        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DiasHorarios { get; set; }
        public decimal Costo { get; set; }
        public int CupoMaximo { get; set; }
        public Profesor Profesor { get; set; }
        public List<Socio> Participantes { get; set; } = new List<Socio>();

        public bool ConsultarDisponibilidad()
        {
            return false;
        }

        public void InscribirParticipante(Socio socio)
        {
        }

        public void DarBajaParticipante(Socio socio)
        {
        }

        public void VerParticipantes()
        {
        }
    }
}