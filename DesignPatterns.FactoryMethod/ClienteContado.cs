namespace DesignPatterns.FactoryMethod
{
    public class ClienteContado : Cliente
    {
        protected override Pedido CreaPedido(double importe)
        {
            return new PedidoContado(importe);
        }
    }
}
