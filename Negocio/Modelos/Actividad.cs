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
            int disponibilidad) : this(nombre, descripcion, diasHorarios, costo, cupoMaximo)
        {
            Disponibilidad = disponibilidad;
        }

        public Actividad(string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo,
            int disponibilidad,
            Profesor profesor) : this(nombre, descripcion, diasHorarios, costo, cupoMaximo, disponibilidad)
        {
            Profesor = profesor;
        }

        public Actividad(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public Actividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo) : this(id, nombre)
        {
            Descripcion = descripcion;
            DiasHorarios = diasHorarios;
            Costo = costo;
            CupoMaximo = cupoMaximo;
        }

        public Actividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo,
            int cupoMaximo, int disponibilidad) : this(id, nombre, descripcion, diasHorarios, costo, cupoMaximo)
        {
            Disponibilidad = disponibilidad;
        }

        public Actividad(int id, string nombre, string descripcion, string diasHorarios, decimal costo, int cupoMaximo,
            int disponibilidad,
            Profesor profesor) : this(id, nombre, descripcion, diasHorarios, costo, cupoMaximo, disponibilidad)
        {
            Profesor = profesor;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DiasHorarios { get; set; }
        public decimal Costo { get; set; }
        public int CupoMaximo { get; set; }
        public int Disponibilidad { get; set; }
        public Profesor Profesor { get; set; }
    }
}