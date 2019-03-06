public class PedidoValidado : EstadoPedido
{
    public PedidoValidado(Pedido pedido)
        : base
    (pedido) { }

    public override void agregaProducto(Producto producto) { }

    public override void borra()
    {
        pedido.Productos.Clear();
    }

    public override void suprimeProducto(Producto producto) { }

    public override EstadoPedido estadoSiguiente()
    {
        return new PedidoEntregado(pedido);
    }
}