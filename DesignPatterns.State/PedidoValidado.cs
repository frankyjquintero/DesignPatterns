namespace DesignPatterns.State
{
    public class PedidoValidado : EstadoPedido
    {
        public PedidoValidado(Pedido pedido)
            : base
                (pedido) { }

        public override void AgregaProducto(Producto producto) { }

        public override void Borra()
        {
            pedido.Productos.Clear();
        }

        public override void SuprimeProducto(Producto producto) { }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoEntregado(pedido);
        }
    }
}