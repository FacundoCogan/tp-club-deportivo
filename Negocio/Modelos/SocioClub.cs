using System;
using System.Linq;

namespace Negocio.Modelos
{
    public class SocioClub : Socio
    {
        public SocioClub(int dni, string nombre, string apellido, decimal? cuotaSocial = null)
            : base(dni, nombre, apellido, cuotaSocial)
        {
            CuotaSocial = cuotaSocial;
            MaxCantidadActividadesLibres = 5;
        }

        public SocioClub(int id, int dni, string nombre, string apellido, decimal? cuotaSocial = null)
            : this(dni, nombre, apellido, cuotaSocial)
        {
            ID = id;
        }

        public static int MaxCantidadActividadesLibres { get; set; }


        public override decimal CalcularMontoOrdenPago()
        {
            var monto = CuotaSocial.Value;
            var limiteActividadesLibres = Math.Max(0, Actividades.Count - MaxCantidadActividadesLibres);

            monto += Actividades.Skip(MaxCantidadActividadesLibres).Take(limiteActividadesLibres)
                .Sum(actividad => actividad.Costo * 0.5m);

            return monto;
        }
    }
}