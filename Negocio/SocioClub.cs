namespace Negocio
{
    public class SocioClub : Socio
    {
        public decimal CuotaSocial { get; set; }
        public int MaxCantidadActividadesLibres { get; set; }

        public SocioClub(string nombre, string apellido, int dni, decimal cuotaSocial, int maxActividadesLibres)
            : base(nombre, apellido, dni)
        {
            CuotaSocial = cuotaSocial;
            MaxCantidadActividadesLibres = maxActividadesLibres;
        }

        public override decimal CalcularMontoOrdenPago()
        {
            // Custom implementation for SocioClub
            return base.CalcularMontoOrdenPago(); // Replace with custom logic
        }
    }

}
