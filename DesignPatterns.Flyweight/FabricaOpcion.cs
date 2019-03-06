using System;
using System.Collections.Generic;

public class FabricaOpcion
{
    protected IDictionary<string, OpcionVehiculo> opciones
    = new Dictionary<string, OpcionVehiculo>();
    public OpcionVehiculo getOption(string nombre)
    {
        OpcionVehiculo resultado;
        if (opciones.ContainsKey(nombre))
            resultado = opciones[nombre];
        else
        {
            resultado = new OpcionVehiculo(nombre);
            opciones.Add(nombre, resultado);
        }
        return resultado;
    }
}
