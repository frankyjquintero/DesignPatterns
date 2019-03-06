using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class OpcionVehiculo
    {
        protected string nombre;
        public IList<OpcionVehiculo> OpcionesIncompatibles
        { get; protected set; }

        public OpcionVehiculo(string nombre)
        {
            OpcionesIncompatibles = new List<OpcionVehiculo>();
            this.nombre = nombre;
        }

        public void AgregaOpcionIncompatible(OpcionVehiculo
            opcionIncompatible)
        {
            if (!OpcionesIncompatibles.Contains(opcionIncompatible))
            {
                OpcionesIncompatibles.Add(opcionIncompatible);
                opcionIncompatible.AgregaOpcionIncompatible(this);
            }
        }

        public void Visualiza()
        {
            Console.WriteLine("opción: " + nombre);
        }
    }
}
