namespace Negocio
{
    public class SocioActividad : Socio
    {
        public SocioActividad(string nombre, string apellido, int dni) : base(nombre, apellido, dni) { }

        public override decimal CalcularMontoOrdenPago()
        {
            // Custom implementation for SocioActividad
            return base.CalcularMontoOrdenPago(); // Replace with custom logic
        }
    }

}
