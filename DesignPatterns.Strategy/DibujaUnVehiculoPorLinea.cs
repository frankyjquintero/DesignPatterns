using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class DibujaUnVehiculoPorLinea : IDibujaCatalogo
    {

        public void Dibuja(IList<VistaVehiculo> contenido)
        {
            Console.WriteLine(
                "Dibuja los vehículos mostrando un vehículo por línea");
            foreach (VistaVehiculo vistaVehiculo in contenido)
            {
                vistaVehiculo.Dibuja();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
