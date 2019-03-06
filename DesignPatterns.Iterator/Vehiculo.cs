using System;

namespace DesignPatterns.Iterator
{
    public class Vehiculo : Elemento
    {

        public Vehiculo(string descripcion) : base(descripcion) { }

        public void Visualiza()
        {
            Console.WriteLine("Descripción del vehículo: " +
                              descripcion);
        }
    }
}
