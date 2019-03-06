namespace DesignPatterns.TemplateMethod
{
    public class PedidoLuxemburgo : Pedido
    {
        protected override void CalculaIva()
        {
            importeIva = importeSinIva * 0.15;
        }
    }
}
