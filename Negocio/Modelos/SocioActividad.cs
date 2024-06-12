using System.Linq;

namespace Negocio.Modelos
{
    public class SocioActividad : Socio
    {
        public SocioActividad(int id, int dni, string nombre, string apellido) : base(id,
            dni,
            nombre, apellido)
        {
        }

        public override decimal CalcularMontoOrdenPago()
        {
            return Actividades.Sum(actividad => actividad.Costo);
        }
    }
}