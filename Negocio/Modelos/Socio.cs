using System.Collections.Generic;

namespace Negocio.Modelos
{
    public class Socio : Persona
    {
        public Socio(int dni, string nombre, string apellido, decimal? cuotaSocial = null) : base(dni, nombre, apellido)
        {
            CuotaSocial = cuotaSocial;
        }

        public Socio(int id, int dni, string nombre, string apellido, decimal? cuotaSocial = null) : base(id, dni,
            nombre,
            apellido)
        {
            CuotaSocial = cuotaSocial;
        }

        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
        public decimal? CuotaSocial { get; set; }

        public virtual decimal CalcularMontoOrdenPago()
        {
            return 0;
        }
    }
}