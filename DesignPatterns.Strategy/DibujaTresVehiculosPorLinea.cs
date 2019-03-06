using System;
using System.Collections.Generic;

public class DibujaTresVehiculosPorLinea : DibujaCatalogo
{
    public void dibuja(IList<VistaVehiculo> contenido)
    {
        int contador;
        Console.WriteLine(
          "Dibuja los vehículos mostrando tres vehículos por línea");
        contador = 0;
        foreach (VistaVehiculo vistaVehiculo in contenido)
        {
            vistaVehiculo.dibuja();
            contador++;
            if (contador == 3)
            {
                Console.WriteLine();
                contador = 0;
            }
            else
                Console.Write(" ");
        }
        if (contador != 0)
            Console.WriteLine();
        Console.WriteLine();
    }
}
