using System.Collections.Generic;

public class SolicitudRebaja
{
    protected IList<Vehiculo> vehiculosEnStock =
        new List<Vehiculo>();
    protected long hoy;
    protected long tiempoEnStock;
    protected double tasaDescuento;

    public SolicitudRebaja(long hoy, long tiempoEnStock,
      double tasaDescuento)
    {
        this.hoy = hoy;
        this.tiempoEnStock = tiempoEnStock;
        this.tasaDescuento = tasaDescuento;
    }

    public void rebaja(IList<Vehiculo> vehiculos)
    {
        vehiculosEnStock.Clear();
        foreach (Vehiculo vehiculo in vehiculos)
            if (vehiculo.getTiempoEnStock(hoy) >=
              tiempoEnStock)
                vehiculosEnStock.Add(vehiculo);
        foreach (Vehiculo vehiculo in vehiculosEnStock)
            vehiculo.modificaPrecio(1.0 - tasaDescuento);
    }

    public void anula()
    {
        foreach (Vehiculo vehiculo in vehiculosEnStock)
            vehiculo.modificaPrecio(1.0 / (1.0 - tasaDescuento));
    }

    public void restablece()
    {
        foreach (Vehiculo vehiculo in vehiculosEnStock)
            vehiculo.modificaPrecio(1.0 - tasaDescuento);
    }
}
