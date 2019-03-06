using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class VistaCatalogo
    {
        protected IList<VistaVehiculo> contenido =
            new List<VistaVehiculo>();
        protected IDibujaCatalogo dibujo;

        public VistaCatalogo(IDibujaCatalogo dibujo)
        {
            contenido.Add(new VistaVehiculo("vehículo económico"));
            contenido.Add(new VistaVehiculo("vehículo amplio"));
            contenido.Add(new VistaVehiculo("vehículo rápido"));
            contenido.Add(new VistaVehiculo("vehículo confortable"));
            contenido.Add(new VistaVehiculo("vehículo deportivo"));
            this.dibujo = dibujo;
        }

        public void Dibuja()
        {
            dibujo.Dibuja(contenido);
        }
    }
}
