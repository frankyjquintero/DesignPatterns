using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public class Catalogo
    {
        protected IList<Vehiculo> vehiculosStock =
            new List<Vehiculo>();
        protected IList<SolicitudRebaja> solicitudes =
            new List<SolicitudRebaja>();

        public void EjecutaSolicitudRebaja(SolicitudRebaja solicitud)
        {
            solicitudes.Insert(0, solicitud);
            solicitud.Rebaja(vehiculosStock);
        }

        public void AnulaSolicitudRebaja(int orden)
        {
            solicitudes[orden].Anula();
        }

        public void RestableceSolicitudRebaja(int orden)
        {
            solicitudes[orden].Restablece();
        }

        public void Agrega(Vehiculo vehiculo)
        {
            vehiculosStock.Add(vehiculo);
        }

        public void Visualiza()
        {
            foreach (Vehiculo vehiculo in vehiculosStock)
                vehiculo.Visualiza();
        }
    }
}
