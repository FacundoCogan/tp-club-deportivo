namespace Negocio.Modelos
{
    public abstract class Persona
    {
        protected Persona(int dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        protected Persona(int id, int dni, string nombre, string apellido) : this(dni, nombre, apellido)
        {
            ID = id;
        }

        public int ID { get; protected set; }
        public string Nombre { get; protected set; }
        public string Apellido { get; protected set; }
        public int DNI { get; protected set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";

        public override bool Equals(object obj)
        {
            if (obj is Persona persona)
            {
                return DNI == persona.DNI;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{NombreCompleto} ({DNI})";
        }
    }
}