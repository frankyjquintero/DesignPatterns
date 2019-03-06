using System;
using System.Collections.Generic;

namespace DesignPatterns.State
{
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

        public void AgregaProducto(Producto producto)
        {
            estadoPedido.AgregaProducto(producto);
        }

        public void SuprimeProducto(Producto producto)
        {
            estadoPedido.SuprimeProducto(producto);
        }

        public void Borra()
        {
            estadoPedido.Borra();
        }

        public void EstadoSiguiente()
        {
            estadoPedido = estadoPedido.EstadoSiguiente();
        }

        public void Visualiza()
        {
            Console.WriteLine("Contenido del pedido");
            foreach (Producto producto in productos)
                producto.Visualiza();
            Console.WriteLine();
        }
    }
}