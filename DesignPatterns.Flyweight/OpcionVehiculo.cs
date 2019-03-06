using System;

namespace DesignPatterns.Flyweight
{
    public class OpcionVehiculo
    {
        protected string nombre;
        protected string descripcion;
        protected int precioEstandar;

        public OpcionVehiculo(string nombre)
        {
            this.nombre = nombre;
            this.descripcion = "Descripción de " + nombre;
            this.precioEstandar = 100;
        }

        public void Visualiza(int precioDeVenta)
        {
            Console.WriteLine("Opción");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine(descripcion);
            Console.WriteLine("Precio estándar: " + precioEstandar);
            Console.WriteLine("Precio de venta: " + precioDeVenta);
        }
    }
}
