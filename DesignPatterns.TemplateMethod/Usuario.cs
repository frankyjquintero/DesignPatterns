using System;

namespace DesignPatterns.TemplateMethod
{
    public static class Usuario
    {
        private static void Main(string[] args)
        {
            Pedido pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.SetImporteSinIva(10000);
            pedidoEspaña.CalculaPrecioConIva();
            pedidoEspaña.Visualiza();


            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoLuxemburgo.SetImporteSinIva(10000);
            pedidoLuxemburgo.CalculaPrecioConIva();
            pedidoLuxemburgo.Visualiza();
            Console.ReadKey();
        }
    }
}
