using System;

namespace Negocio
{
    public static class Validator
    {
        public static int ValidateDNI(string value)
        {
            if (!int.TryParse(value, out var dni))
            {
                throw new ArgumentException("El DNI debe ser un número");
            }

            if (value.Length != 8)
            {
                throw new ArgumentException("El DNI debe tener 8 dígitos");
            }

            return dni;
        }

        public static decimal? ValidateCuotaSocial(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            if (!decimal.TryParse(value, out var cuotaSocial))
            {
                throw new ArgumentException("La cuota social debe ser un número");
            }

            if (cuotaSocial <= 0)
            {
                throw new ArgumentException("La cuota social debe ser mayor a 0");
            }

            return cuotaSocial;
        }
    }
}