using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public interface IWebServiceAuto
    {
        string Documento(int indice);
        IList<string> BuscaVehiculos(int precioMedio, int
            desviacionMax);
    }
}
