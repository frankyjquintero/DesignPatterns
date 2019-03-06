using System.Collections.Generic;

public class Catalogo
{
    protected IList<Vehiculo> vehiculosStock =
        new List<Vehiculo>();
    protected IList<SolicitudRebaja> solicitudes =
        new List<SolicitudRebaja>();

    public void ejecutaSolicitudRebaja(SolicitudRebaja solicitud)
    {
        solicitudes.Insert(0, solicitud);
        solicitud.rebaja(vehiculosStock);
    }

    public void anulaSolicitudRebaja(int orden)
    {
        solicitudes[orden].anula();
    }

    public void restableceSolicitudRebaja(int orden)
    {
        solicitudes[orden].restablece();
    }

    public void agrega(Vehiculo vehiculo)
    {
        vehiculosStock.Add(vehiculo);
    }

    public void visualiza()
    {
        foreach (Vehiculo vehiculo in vehiculosStock)
            vehiculo.visualiza();
    }
}
