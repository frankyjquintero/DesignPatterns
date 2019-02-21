public class ClienteCredito : Cliente
{
    protected override Pedido creaPedido(double importe)
    {
        return new PedidoCredito(importe);
    }
}
