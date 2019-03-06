namespace DesignPatterns.TemplateMethod
{
    public class PedidoEspaña : Pedido
    {
        protected override void CalculaIva()
        {
            importeIva = importeSinIva * 0.18;
        }
    }
}
