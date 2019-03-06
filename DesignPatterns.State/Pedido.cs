using System;
using System.Collections.Generic;

public class Pedido
{
    protected IList<Producto> productos = new List<Producto>();
    public IList<Producto> Productos
    {
        get
        {
            return productos;
        }
    }
    protected EstadoPedido estadoPedido;

    public Pedido()
    {
        estadoPedido = new PedidoEnCurso(this);
    }

    public void agregaProducto(Producto producto)
    {
        estadoPedido.agregaProducto(producto);
    }

    public void suprimeProducto(Producto producto)
    {
        estadoPedido.suprimeProducto(producto);
    }

    public void borra()
    {
        estadoPedido.borra();
    }

    public void estadoSiguiente()
    {
        estadoPedido = estadoPedido.estadoSiguiente();
    }

    public void visualiza()
    {
        Console.WriteLine("Contenido del pedido");
        foreach (Producto producto in productos)
            producto.visualiza();
        Console.WriteLine();
    }
}