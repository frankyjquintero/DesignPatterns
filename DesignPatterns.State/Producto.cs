using System;

namespace DesignPatterns.State
{
    public class Producto
    {
        protected string nombre;

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }

        public void Visualiza()
        {
            Console.WriteLine("Producto: " + nombre);
        }
    }
}
