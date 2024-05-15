namespace Negocio.Modelos
{
    public class SocioClub : Socio
    {
        public static int MaxCantidadActividadesLibres { get; set; }

        public SocioClub(int dni, string nombre, string apellido, decimal? cuotaSocial)
            : base(dni, nombre, apellido, cuotaSocial)
        {
            CuotaSocial = cuotaSocial;
            MaxCantidadActividadesLibres = 5;
        }

        public SocioClub(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
            : this(dni, nombre, apellido, cuotaSocial)
        {
            ID = id;
        }


        public override decimal CalcularMontoOrdenPago()
        {
            decimal monto = 0;
            if(Actividades.Count > MaxCantidadActividadesLibres)
            {
                for (int i = MaxCantidadActividadesLibres; i < Actividades.Count; i++)
                {
                    monto += CuotaSocial.Value + (Actividades[i].Costo * 0.5m);
                }
            }
            else
            {
                monto = CuotaSocial.Value;
            }
            return monto;

        }
    }
}