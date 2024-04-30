using System;

namespace Negocio.Modelos
{
    public class OrdenPago
    {
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Pagada { get; set; }
    }

}
