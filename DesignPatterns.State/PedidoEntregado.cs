namespace DesignPatterns.State
{
    public class PedidoEntregado : EstadoPedido
    {
        public PedidoEntregado(Pedido pedido)
            : base(pedido)
        { }

        public override void AgregaProducto(Producto producto) { }

        public override void Borra() { }

        public override void SuprimeProducto(Producto producto) { }

        public override EstadoPedido EstadoSiguiente()
        {
            return this;
        }
    }
}