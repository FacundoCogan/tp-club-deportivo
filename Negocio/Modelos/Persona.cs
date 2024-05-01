namespace Negocio.Modelos
{
    public class Persona
    {
        public Persona()
        {
        }

        public Persona(int dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

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