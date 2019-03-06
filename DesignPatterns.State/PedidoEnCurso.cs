namespace DesignPatterns.State
{
    public class PedidoEnCurso : EstadoPedido
    {
        public PedidoEnCurso(Pedido pedido)
            : base
                (pedido) { }

        public override void AgregaProducto(Producto producto)
        {
            pedido.Productos.Add(producto);
        }

        public override void Borra()
        {
            pedido.Productos.Clear();
        }

        public override void SuprimeProducto(Producto producto)
        {
            pedido.Productos.Remove(producto);
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoValidado(pedido);
        }
    }
}