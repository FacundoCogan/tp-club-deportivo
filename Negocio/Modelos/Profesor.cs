using System.Collections.Generic;

namespace Negocio.Modelos
{
    public class Profesor : Persona
    {
        public Profesor(int dni, string nombre, string apellido, string especialidad)
            : base(dni, nombre, apellido)
        {
            Especialidad = especialidad;
            Actividades = new List<Actividad>();
        }

        public Profesor(int id, int dni, string nombre, string apellido, string especialidad) : this(dni, nombre,
            apellido, especialidad)
        {
            ID = id;
        }

        public string Especialidad { get; set; }
        public List<Actividad> Actividades { get; set; }


        public void VerActividades()
        {
        }
    }
}