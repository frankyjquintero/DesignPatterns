using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public interface IDibujaCatalogo
    {
        void Dibuja(IList<VistaVehiculo> contenido);
    }
}
