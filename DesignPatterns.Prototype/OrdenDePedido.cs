using System;

namespace DesignPatterns.Prototype
{
    public class OrdenDePedido : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine("Muestra la orden de pedido: " +
                              contenido);
        }

        public override void Imprime()
        {
            Console.WriteLine("Imprime la orden de pedido: " +
                              contenido);
        }
    }
}
