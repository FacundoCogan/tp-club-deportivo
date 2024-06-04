using System;

namespace Negocio.Modelos
{
    public class OrdenPago
    {
        public OrdenPago(int socioID, decimal monto)
        {
            SocioID = socioID;
            Monto = monto;
        }

        public OrdenPago(int socioID, decimal monto, DateTime fecha, bool pagada) : this(socioID, monto)
        {
            Fecha = fecha;
            Pagada = pagada;
        }

        // Constructor generado para poder hacer la lista de ordenes de pago pendientes
        public OrdenPago(int id, int socioID, decimal monto, DateTime fecha) : this(socioID, monto)
        {
            ID = id;
            Fecha = fecha;
        }

        public OrdenPago(int id, int socioID, decimal monto, DateTime fecha, bool pagada)
        {
            ID = id;
            SocioID = socioID;
            Monto = monto;
            Fecha = fecha;
            Pagada = pagada;
        }

        public int ID { get; set; }
        public int SocioID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Pagada { get; set; }
    }
}