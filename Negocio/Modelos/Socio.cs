using System.Collections.Generic;

namespace Negocio.Modelos
{
    public class Socio : Persona
    {
        public Socio(int dni, string nombre, string apellido, decimal? cuotaSocial) : base(dni, nombre, apellido)
        {
            CuotaSocial = cuotaSocial;
        }

        public Socio(int id, int dni, string nombre, string apellido, decimal? cuotaSocial) : base(id, dni, nombre,
            apellido)
        {
            CuotaSocial = cuotaSocial;
        }

        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
        public List<OrdenPago> OrdenesPago { get; set; } = new List<OrdenPago>();
        public decimal? CuotaSocial { get; set; }


        public virtual void Pagar()
        {
        }

        public virtual void InscribirseActividad()
        {
        }

        public virtual void DarBajaActividad()
        {
        }

        public virtual decimal CalcularMontoOrdenPago()
        {
            return 0;
            // Default implementation
        }

        public virtual void ConsultarActividades()
        {
        }

        public virtual decimal ConsultarDeuda()
        {
            return 0;
            // Default implementation
        }
    }
}