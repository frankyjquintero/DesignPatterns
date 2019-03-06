using System;

public class Vehiculo
{
    protected string nombre;
    protected long fechaEntradaStock;
    protected double precioVenta;

    public Vehiculo(string nombre, long fechaEntradaStock,
      double precioVenta)
    {
        this.nombre = nombre;
        this.fechaEntradaStock = fechaEntradaStock;
        this.precioVenta = precioVenta;
    }

    public long getTiempoEnStock(long hoy)
    {
        return hoy - fechaEntradaStock;
    }

    public void modificaPrecio(double coeficiente)
    {
        this.precioVenta = 0.01 * Math.Round(coeficiente *
        this.precioVenta * 100);
    }

    public void visualiza()
    {
        Console.WriteLine(nombre + " precio: " + precioVenta +
          " fecha entrada stock " + fechaEntradaStock);
    }
}
