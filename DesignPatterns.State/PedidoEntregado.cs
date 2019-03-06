public class PedidoEntregado : EstadoPedido
{
    public PedidoEntregado(Pedido pedido)
        : base(pedido)
    { }

    public override void agregaProducto(Producto producto) { }

    public override void borra() { }

    public override void suprimeProducto(Producto producto) { }

    public override EstadoPedido estadoSiguiente()
    {
        return this;
    }
}