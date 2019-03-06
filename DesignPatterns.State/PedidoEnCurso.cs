public class PedidoEnCurso : EstadoPedido
{
    public PedidoEnCurso(Pedido pedido)
        : base
    (pedido) { }

    public override void agregaProducto(Producto producto)
    {
        pedido.Productos.Add(producto);
    }

    public override void borra()
    {
        pedido.Productos.Clear();
    }

    public override void suprimeProducto(Producto producto)
    {
        pedido.Productos.Remove(producto);
    }

    public override EstadoPedido estadoSiguiente()
    {
        return new PedidoValidado(pedido);
    }
}