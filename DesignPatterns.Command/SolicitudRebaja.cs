using System.Collections.Generic;

namespace DesignPatterns.Command
{
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

        public void Rebaja(IList<Vehiculo> vehiculos)
        {
            vehiculosEnStock.Clear();
            foreach (Vehiculo vehiculo in vehiculos)
                if (vehiculo.GetTiempoEnStock(hoy) >=
                    tiempoEnStock)
                    vehiculosEnStock.Add(vehiculo);
            foreach (Vehiculo vehiculo in vehiculosEnStock)
                vehiculo.ModificaPrecio(1.0 - tasaDescuento);
        }

        public void Anula()
        {
            foreach (Vehiculo vehiculo in vehiculosEnStock)
                vehiculo.ModificaPrecio(1.0 / (1.0 - tasaDescuento));
        }

        public void Restablece()
        {
            foreach (Vehiculo vehiculo in vehiculosEnStock)
                vehiculo.ModificaPrecio(1.0 - tasaDescuento);
        }
    }
}
