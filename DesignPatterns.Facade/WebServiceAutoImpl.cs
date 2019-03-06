using System;
using System.Collections.Generic;

public class WebServiceAutoImpl : WebServiceAuto
{
    protected Catalogo catalogo = new ComponenteCatalogo();
    protected GestionDocumento gestionDocumento = new
      ComponenteGestionDocumento();

    public string documento(int indice)
    {
        return gestionDocumento.documento(indice);
    }

    public IList<string> buscaVehiculos(int precioMedio,
      int desviacionMax)
    {
        return catalogo.buscaVehiculos(precioMedio -
          desviacionMax, precioMedio + desviacionMax);
    }
}
