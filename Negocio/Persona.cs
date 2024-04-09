using System;

namespace Negocio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private string _dni;
        public string DNI
        {
            get => _dni;
            set
            {
                if (!int.TryParse(value, out _))
                {
                    throw new Exception("El DNI debe ser un número");
                }

                if (value.Length != 8)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }

                _dni = value;
            }
        }

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
