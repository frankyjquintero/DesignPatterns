using System;

public class VistaCatalogo
{
    static void Main(string[] args)
    {
        VistaVehiculo vistaVehiculo = new VistaVehiculo();
        ModeloDecorador modeloDecorador = new
          ModeloDecorador(vistaVehiculo);
        MarcaDecorador marcaDecorador = new
          MarcaDecorador(modeloDecorador);
        marcaDecorador.visualiza();
    }
}
