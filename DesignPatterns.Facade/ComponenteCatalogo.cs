using System;
using System.Collections.Generic;

public class ComponenteCatalogo : Catalogo
{
    protected object[] descripcionVehiculo = 
  {
    "Berlina 5 puertas", 6000, "Compacto 3 puertas", 4000, 
    "Espace 5 puertas", 8000, "Break 5 puertas", 7000, 
    "Coupé 2 puertas", 9000, "Utilitario 3 puertas", 5000
  };

    public IList<string> buscaVehiculos(int precioMin,
      int precioMax)
    {
        int indice, tamaño;
        IList<string> resultado = new List<string>();
        tamaño = descripcionVehiculo.Length / 2;
        for (indice = 0; indice < tamaño; indice++)
        {
            int precio = (int)descripcionVehiculo[2 * indice + 1];
            if ((precio >= precioMin) && (precio <= precioMax))
                resultado.Add((string)descripcionVehiculo[2 *
                indice]);
        }
        return resultado;
    }
}
