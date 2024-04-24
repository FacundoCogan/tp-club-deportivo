using System.Collections.Generic;

namespace Negocio
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }
        public List<Actividad> Actividades { get; set; }


        public Profesor(string nombre, string apellido, int dni, string especialidad)
            : base(nombre, apellido, dni)
        {
            Especialidad = especialidad;
            Actividades = new List<Actividad>();
        }


        public void VerActividades()
        {

        }
    }


}
