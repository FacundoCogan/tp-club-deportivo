namespace Negocio.Modelos
{
    public class SocioActividad : Socio
    {
        public SocioActividad(int id, int dni, string nombre, string apellido, decimal? cuotaSocial) : base(id, dni,
            nombre, apellido, cuotaSocial)
        {
        }

        public override decimal CalcularMontoOrdenPago()
        {
            decimal monto = 0;
            foreach (var actividad in Actividades)
            {
                monto += actividad.Costo;
            }
            return monto;
        }
    }
}