using System.Linq;

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
            return Actividades.Sum(actividad => actividad.Costo);
        }
    }
}