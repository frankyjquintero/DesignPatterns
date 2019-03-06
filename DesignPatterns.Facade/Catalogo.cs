using System;
using System.Collections.Generic;

public interface Catalogo
{
    IList<string> buscaVehiculos(int precioMin, int
      precioMax);
}
