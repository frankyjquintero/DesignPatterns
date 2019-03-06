public class PedidoEspaña : Pedido
{
    protected override void calculaIVA()
    {
        importeIVA = importeSinIVA * 0.18;
    }
}
