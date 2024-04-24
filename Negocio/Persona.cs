using System;

namespace Negocio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string n, string a, int d)
        {
            Nombre = n;
            Apellido = a;
            DNI = d;
        }

        // ------------------------ PROPIEDADES ------------------------ //

        private int _dni;
        public int DNI
        {   get => _dni;
            set
            {
                if (value.ToString().Length < 8)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }

                _dni = value;
            }
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} ({DNI})";
        }
    }

}
