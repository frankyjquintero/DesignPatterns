using System;
using System.Collections.Generic;

public class CarritoOpciones
{
    protected IList<OpcionVehiculo> opciones =
      new List<OpcionVehiculo>();

    public Memento agregaOpcion(OpcionVehiculo
    opcionVehiculo)
    {
        MementoImpl resultado = new MementoImpl();
        resultado.estado = opciones;
        IList<OpcionVehiculo> opcionesIncompatibles =
          opcionVehiculo.opcionesIncompatibles;
        foreach (OpcionVehiculo opcion in
          opcionesIncompatibles)
            opciones.Remove(opcion);
        opciones.Add(opcionVehiculo);
        return resultado;
    }

    public void anula(Memento memento)
    {
        MementoImpl mementoImplInstance = memento as MementoImpl;
        if (mementoImplInstance == null)
            return;
        opciones = mementoImplInstance.estado;
    }

    public void visualiza()
    {
        Console.WriteLine("Contenido del carrito de opciones");
        foreach (OpcionVehiculo opcion in opciones)
            opcion.visualiza();
        Console.WriteLine();
    }
}
