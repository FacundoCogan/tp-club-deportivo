﻿using System.Collections.Generic;

namespace Negocio
{
    public class Socio : Persona
    {
        public List<Actividad> Actividades { get; set; }
        public List<OrdenPago> OrdenesPago { get; set; }

        public Socio(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            Actividades = new List<Actividad>();
            OrdenesPago = new List<OrdenPago>();
        }

        public virtual void Pagar() { }
        public virtual void InscribirseActividad() { }
        public virtual void DarBajaActividad() { }
        public virtual decimal CalcularMontoOrdenPago() => 0; // Default implementation
        public virtual void ConsultarActividades() { }
        public virtual decimal ConsultarDeuda() => 0; // Default implementation
    }

}
