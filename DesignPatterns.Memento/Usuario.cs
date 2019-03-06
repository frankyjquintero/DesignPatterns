using System;

namespace DesignPatterns.Memento
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            IMemento memento;
            OpcionVehiculo opcion1 = new OpcionVehiculo(
                "Asientos en cuero");
            OpcionVehiculo opcion2 = new OpcionVehiculo(
                "Reclinables");
            OpcionVehiculo opcion3 = new OpcionVehiculo(
                "Asientos deportivos");
            opcion1.AgregaOpcionIncompatible(opcion3);
            opcion2.AgregaOpcionIncompatible(opcion3);
            CarritoOpciones carritoOpciones = new CarritoOpciones();
            carritoOpciones.AgregaOpcion(opcion1);
            carritoOpciones.AgregaOpcion(opcion2);
            carritoOpciones.Visualiza();
            memento = carritoOpciones.AgregaOpcion(opcion3);
            carritoOpciones.Visualiza();
            carritoOpciones.Anula(memento);
            carritoOpciones.Visualiza();
            Console.ReadKey();
        }
    }
}
