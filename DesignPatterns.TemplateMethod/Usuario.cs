using System;
public class Usuario
{
    static void Main(string[] args)
    {
        Pedido pedidoEspaña = new PedidoEspaña();
        pedidoEspaña.setImporteSinIVA(10000);
        pedidoEspaña.calculaPrecioConIVA();
        pedidoEspaña.visualiza();


        Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
        pedidoLuxemburgo.setImporteSinIVA(10000);
        pedidoLuxemburgo.calculaPrecioConIVA();
        pedidoLuxemburgo.visualiza();
    }
}
