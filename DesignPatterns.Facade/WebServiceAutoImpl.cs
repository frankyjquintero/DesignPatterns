using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public class WebServiceAutoImpl : IWebServiceAuto
    {
        protected ICatalogo catalogo = new ComponenteCatalogo();
        protected IGestionDocumento gestionDocumento = new
            ComponenteGestionDocumento();

        public string Documento(int indice)
        {
            return gestionDocumento.Documento(indice);
        }

        public IList<string> BuscaVehiculos(int precioMedio,
            int desviacionMax)
        {
            return catalogo.BuscaVehiculos(precioMedio -
                                           desviacionMax, precioMedio + desviacionMax);
        }
    }
}
