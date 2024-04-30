namespace Negocio.Modelos
{
    public class SocioActividad : Socio
    {
        public SocioActividad(int dni, string nombre, string apellido) : base(dni, nombre, apellido) { }

        public override decimal CalcularMontoOrdenPago()
        {
            // Custom implementation for SocioActividad
            return base.CalcularMontoOrdenPago(); // Replace with custom logic
        }
    }

}
