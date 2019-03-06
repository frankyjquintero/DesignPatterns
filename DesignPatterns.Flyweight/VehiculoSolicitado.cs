using System;
using System.Collections.Generic;

public class VehiculoSolicitado
{
    protected IList<OpcionVehiculo> opciones =
        new List<OpcionVehiculo>();
    protected IList<int> precioDeVentaOpciones =
        new List<int>();

    public void agregaOpciones(string nombre, int precioDeVenta,
      FabricaOpcion fabrica)
    {
        opciones.Add(fabrica.getOption(nombre));
        precioDeVentaOpciones.Add(precioDeVenta);
    }

    public void muestraOpciones()
    {
        int indice, tamaño;
        tamaño = opciones.Count;
        for (indice = 0; indice < tamaño; indice++)
        {
            opciones[indice].visualiza(
            precioDeVentaOpciones[indice]);
            Console.WriteLine();
        }
    }
}
