using System;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Pedido
    {
        protected double importeSinIva;
        protected double importeIva;
        protected double importeConIva;

        protected abstract void CalculaIva();

        public void CalculaPrecioConIva()
        {
            this.CalculaIva();
            importeConIva = importeSinIva + importeIva;
        }

        public void SetImporteSinIva(double importeSinIva)
        {
            this.importeSinIva = importeSinIva;
        }

        public void Visualiza()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine("Importe sin IVA " + importeSinIva);
            Console.WriteLine("Importe con IVA " + importeConIva);
        }
    }
}
