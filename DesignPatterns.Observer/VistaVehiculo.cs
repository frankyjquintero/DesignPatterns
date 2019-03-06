using System;

namespace DesignPatterns.Observer
{
    public class VistaVehiculo : IObservador
    {
        protected Vehiculo vehiculo;
        protected string texto = "";

        public VistaVehiculo(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
            vehiculo.Agrega(this);
            ActualizaTexto();
        }

        protected void ActualizaTexto()
        {
            texto = "Descripción " + vehiculo.Descripcion +
                    " Precio: " + vehiculo.Precio;
        }

        public void Actualiza()
        {
            ActualizaTexto();
            this.Redibuja();
        }

        public void Redibuja()
        {
            Console.WriteLine(texto);
        }
    }
}
