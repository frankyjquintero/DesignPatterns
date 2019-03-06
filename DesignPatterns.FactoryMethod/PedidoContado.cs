using System;

namespace DesignPatterns.FactoryMethod
{
    public class PedidoContado : Pedido
    {
        public PedidoContado(double importe) : base(importe) { }

        public override void Paga()
        {
            Console.WriteLine(
                "El pago del pedido por importe de: " +
                importe + " se ha realizado.");
        }

        public override bool Valida()
        {
            return true;
        }
    }
}
