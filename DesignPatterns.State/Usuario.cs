using System;

namespace DesignPatterns.State
{
    public static class Usuario
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.AgregaProducto(new Producto("vehículo 1"));
            pedido.AgregaProducto(new Producto("accesorio 2"));
            pedido.Visualiza();
            pedido.EstadoSiguiente();
            pedido.AgregaProducto(new Producto("accesorio 3"));
            pedido.Borra();
            pedido.Visualiza();

            Pedido pedido2 = new Pedido();
            pedido2.AgregaProducto(new Producto("vehículo 11"));
            pedido2.AgregaProducto(new Producto("accesorio 21"));
            pedido2.Visualiza();
            pedido2.EstadoSiguiente();
            pedido2.Visualiza();
            pedido2.EstadoSiguiente();
            pedido2.Borra();
            pedido2.Visualiza();
            Console.ReadKey();
        }
    }
}