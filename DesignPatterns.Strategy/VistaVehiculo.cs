using System;

namespace DesignPatterns.Strategy
{
    public class VistaVehiculo
    {
        protected string descripcion;

        public VistaVehiculo(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void Dibuja()
        {
            Console.Write(descripcion);
        }
    }
}
