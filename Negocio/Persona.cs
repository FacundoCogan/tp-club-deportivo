namespace Negocio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} ({DNI})";
        }
    }

}
