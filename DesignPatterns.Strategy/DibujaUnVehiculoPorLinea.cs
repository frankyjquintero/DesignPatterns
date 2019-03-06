using System;
using System.Collections.Generic;

public class DibujaUnVehiculoPorLinea : DibujaCatalogo
{

    public void dibuja(IList<VistaVehiculo> contenido)
    {
        Console.WriteLine(
          "Dibuja los vehículos mostrando un vehículo por línea");
        foreach (VistaVehiculo vistaVehiculo in contenido)
        {
            vistaVehiculo.dibuja();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
