namespace Negocio.Modelos
{
    public class SocioClub : Socio
    {
        public SocioClub(int dni, string nombre, string apellido, decimal? cuotaSocial)
            : base(dni, nombre, apellido, cuotaSocial)
        {
            CuotaSocial = cuotaSocial;
            //MaxCantidadActividadesLibres = maxActividadesLibres;
        }

        public SocioClub(int id, int dni, string nombre, string apellido, decimal? cuotaSocial)
            : this(dni, nombre, apellido, cuotaSocial)
        {
            ID = id;
        }

        public int MaxCantidadActividadesLibres { get; set; }


        public override decimal CalcularMontoOrdenPago()
        {
            // Custom implementation for SocioClub
            return base.CalcularMontoOrdenPago(); // Replace with custom logic
        }
    }
}