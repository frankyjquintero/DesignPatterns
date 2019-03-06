using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class CarritoOpciones
    {
        protected IList<OpcionVehiculo> opciones =
            new List<OpcionVehiculo>();

        public IMemento AgregaOpcion(OpcionVehiculo
            opcionVehiculo)
        {
            MementoImpl resultado = new MementoImpl();
            resultado.Estado = opciones;
            IList<OpcionVehiculo> opcionesIncompatibles =
                opcionVehiculo.OpcionesIncompatibles;
            foreach (OpcionVehiculo opcion in
                opcionesIncompatibles)
                opciones.Remove(opcion);
            opciones.Add(opcionVehiculo);
            return resultado;
        }

        public void Anula(IMemento memento)
        {
            MementoImpl mementoImplInstance = memento as MementoImpl;
            if (mementoImplInstance == null)
                return;
            opciones = mementoImplInstance.Estado;
        }

        public void Visualiza()
        {
            Console.WriteLine("Contenido del carrito de opciones");
            foreach (OpcionVehiculo opcion in opciones)
                opcion.Visualiza();
            Console.WriteLine();
        }
    }
}
