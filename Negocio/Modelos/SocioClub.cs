namespace Negocio.Modelos
{
    public class SocioClub : Socio
    {
        public decimal CuotaSocial { get; set; }
        public int MaxCantidadActividadesLibres { get; set; }

        public SocioClub(int dni, string nombre, string apellido, decimal cuotaSocial)
            : base(dni, nombre, apellido)
        {
            CuotaSocial = cuotaSocial;
            //MaxCantidadActividadesLibres = maxActividadesLibres;
        }

        public override decimal CalcularMontoOrdenPago()
        {
            // Custom implementation for SocioClub
            return base.CalcularMontoOrdenPago(); // Replace with custom logic
        }
    }

}
