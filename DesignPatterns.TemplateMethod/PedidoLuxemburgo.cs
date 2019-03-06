public class PedidoLuxemburgo : Pedido
{
    protected override void calculaIVA()
    {
        importeIVA = importeSinIVA * 0.15;
    }
}
