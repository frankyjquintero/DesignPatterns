using System;
using System.Collections.Generic;

public interface WebServiceAuto
{
  string documento(int indice);
  IList<string> buscaVehiculos(int precioMedio, int
    desviacionMax);
}
