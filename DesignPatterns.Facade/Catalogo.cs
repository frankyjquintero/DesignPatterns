using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public interface ICatalogo
    {
        IList<string> BuscaVehiculos(int precioMin, int
            precioMax);
    }
}
